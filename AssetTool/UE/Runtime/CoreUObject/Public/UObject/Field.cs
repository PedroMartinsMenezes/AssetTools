using System.Collections.Immutable;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class FField : ITransferable
    {
        public const string TYPE_NAME = "Field";
        public virtual string TypeName { get; }

        public FName NamePrivate;
        public EObjectFlags FlagsPrivate;
        public bool HasMetaData;
        public Dictionary<FName, FString> MetaDataMap = [];

        [Location("void FField::Serialize(FArchive& Ar)")]
        public virtual FField Move(Transfer transfer)
        {
            transfer.Move(ref NamePrivate);
            transfer.MoveEnum(ref FlagsPrivate);
            if (!transfer.GlobalObjects.IsFilterEditorOnly() && !transfer.GlobalObjects.HasCooked())
            {
                transfer.Move(ref HasMetaData);
                if (HasMetaData)
                {
                    transfer.Move(ref MetaDataMap);
                }
            }
            return this;
        }

        ITransferable ITransferable.Move(Transfer transfer)
        {
            Move(transfer);
            return this;
        }

        [Location("FField* FField::Construct(const FName& FieldTypeName, const FFieldVariant& InOwner, const FName& InName, EObjectFlags InFlags)")]
        public static FField Construct(FName FieldTypeName)
        {
            if (FFieldClass.GetNameToFieldClassMap().TryGetValue(FieldTypeName.Value, out var FieldClassPtr))
            {
                return FieldClassPtr();
            }
            else
            {
                string msg = $"\nField type {FieldTypeName.Value} does not exist\n";
                Log.Error(msg);
                throw new InvalidOperationException(msg);
            }
        }

        [Location("inline void SerializeSingleField(FArchive& Ar, FieldType*& Field, FFieldVariant Owner)")]
        public static void SerializeSingleField(Transfer transfer, ref FName PropertyTypeName, ref FField Field)
        {
            transfer.Move(ref PropertyTypeName);
            if (PropertyTypeName.IsFilled())
            {
                Field = Field ?? FField.Construct(PropertyTypeName);
                Field.Move(transfer);
            }
        }

        public virtual FProperty Read(JsonProperty elem, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }

        public virtual void Write(Utf8JsonWriter writer, JsonSerializerOptions options)
        {
            writer.WriteString("__type", this.GetType().Name);
            JsonElement element = JsonSerializer.SerializeToElement(this, options);

            foreach (JsonProperty property in element.EnumerateObject())
            {
                property.WriteTo(writer);
            }
        }

        #region Custom JsonConverter
        protected static T ReadKeyValue<T>(string key, JsonElement root) where T : FProperty, new()
        {
            T value = new T();

            //Base members
            value.PropertyFlags = key.GetNonNull("PropertyFlags({0})", x => Enum.Parse<EPropertyFlags>(x), EPropertyFlags.CPF_None);
            value.FlagsPrivate = key.GetNonNull("FlagsPrivate({0})", x => Enum.Parse<EObjectFlags>(x), EObjectFlags.RF_Public);
            value.ArrayDim = key.GetNonNull("ArrayDim({0})", x => int.Parse(x), 1);
            value.RepIndex = key.GetNonNull("RepIndex({0})", x => ushort.Parse(x), (ushort)0);
            value.RepNotifyFunc = key.GetNonNull("RepNotifyFunc({0})", x => new FName(x), new FName("None"));
            value.BlueprintReplicationCondition = key.GetNonNull("BlueprintReplicationCondition({0})", x => byte.Parse(x), (byte)0);

            //MetaDataMap inlined
            string metadataMap = key.GetNonNull("MetaDataMap( {0} ) ", x => x);
            if (metadataMap is { })
            {
                value.HasMetaData = true;
                string[] parts = metadataMap[..^2].Split("•) ");
                foreach (string part in parts)
                {
                    string name = part[0..part.IndexOf("(•")];
                    string val = part[(part.IndexOf("(•") + 2)..];
                    value.MetaDataMap.Add(new FName(name), new FString(val));
                }
            }

            value.NamePrivate = key.GetNonNull("NamePrivate(•{0}•)", x => new FName(x));

            return value;
        }

        protected static void WriteKeyValue<T>(Utf8JsonWriter writer, JsonSerializerOptions options, T value, string name, Dictionary<string, object> inlineFields = null, Dictionary<string, object> fields = null) where T : FProperty
        {
            StringBuilder builder = new();

            builder.Append($"{name} ");

            //Base members
            if (value.PropertyFlags != EPropertyFlags.CPF_None) builder.Append($"PropertyFlags({value.PropertyFlags}) ");
            if (value.FlagsPrivate != EObjectFlags.RF_Public) builder.Append($"FlagsPrivate({value.FlagsPrivate}) ");
            if (value.ArrayDim != 1) builder.Append($"ArrayDim({value.ArrayDim}) ");
            if (value.RepIndex != 0) builder.Append($"RepIndex({value.RepIndex}) ");
            if (value.RepNotifyFunc.Value != "None") builder.Append($"RepNotifyFunc({value.RepNotifyFunc}) ");
            if (value.BlueprintReplicationCondition != 0) builder.Append($"BlueprintReplicationCondition({value.BlueprintReplicationCondition}) ");

            //Derived members inlined
            if (inlineFields is { } && inlineFields.Count > 0)
            {
                foreach (var pair in inlineFields)
                {
                    if (pair.Value is { })
                    {
                        builder.Append($"{pair.Key}({pair.Value}) ");
                    }
                    else
                    {
                        builder.Append($"{pair.Key} ");
                    }
                }
            }

            //MetaDataMap inlined
            if (value.HasMetaData)
            {
                builder.Append("MetaDataMap( ");
                foreach (var pair in value.MetaDataMap)
                {
                    builder.Append($"{pair.Key}(•{pair.Value}•) ");
                }
                builder.Append(") ");
            }

            //NamePrivate
            builder.Append($"NamePrivate(•{value.NamePrivate}•) ");

            string key = builder.ToString();

            if (fields is null)
            {
                writer.WriteString(key, string.Empty);
            }
            else
            {
                writer.WritePropertyName(key);

                writer.WriteStartObject();
                foreach (var pair in fields)
                {
                    if (pair.Value is FField field)
                    {
                        writer.WritePropertyName(pair.Key);
                        JsonSerializer.Serialize(writer, field, options);
                    }
                    else
                    {
                        writer.WritePropertyName(pair.Key);
                        JsonSerializer.Serialize(writer, pair.Value, options);
                    }
                }
                writer.WriteEndObject();
            }
        }
        #endregion
    }

    public sealed class FFieldJsonConverter : JsonConverter<FField>
    {
        public override FField Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            JsonElement root = document.RootElement;
            if (root.TryGetProperty("__type", out _))
            {
                string typeName = root.GetProperty("__type").GetString();
                Type correctType = FFieldClass.PropertyTypes[typeName];
                return (FField)JsonSerializer.Deserialize(root.GetRawText(), correctType, options);
            }
            else
            {
                JsonProperty prop = root.EnumerateObject().First();
                string key = prop.Name[0..prop.Name.IndexOf(' ')];
                if (!FFieldClass.PropertyTypesByPrefix.TryGetValue(key, out Type correctType))
                {
                    throw new JsonException($"Unknown field key '{key}'.");
                }
                FField field = (FField)Activator.CreateInstance(correctType);

                return field.Read(prop, options);
            }
        }

        public override void Write(Utf8JsonWriter writer, FField value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            value.Write(writer, options);
            writer.WriteEndObject();
        }
    }

    public sealed class FFieldListJsonConverter : JsonConverter<List<FField>>
    {
        public override List<FField> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            List<FField> fields = [];
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            JsonElement root = document.RootElement;
            foreach (JsonProperty elem in root.EnumerateObject())
            {
                string name = elem.Name;
                string key = name[0..name.IndexOf(' ')];
                if (!FFieldClass.PropertyTypesByPrefix.TryGetValue(key, out Type correctType))
                {
                    throw new JsonException($"Unknown field key '{key}'.");
                }
                FField field = (FField)Activator.CreateInstance(correctType);
                field = field.Read(elem, options);
                fields.Add(field);
            }
            return fields;
        }

        public override void Write(Utf8JsonWriter writer, List<FField> value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            foreach (FField field in value)
            {
                field.Write(writer, options);
            }
            writer.WriteEndObject();
        }
    }

    public static class FFieldClass
    {
        private static Dictionary<string, Func<FField>> NameToFieldClassMap { get; set; } = [];

        public static readonly ImmutableDictionary<string, Type> PropertyTypes = ImmutableDictionary.CreateRange(new Dictionary<string, Type>
        {
            [nameof(FArrayProperty)] = typeof(FArrayProperty),
            [nameof(FBoolProperty)] = typeof(FBoolProperty),
            [nameof(FByteProperty)] = typeof(FByteProperty),
            [nameof(FClassProperty)] = typeof(FClassProperty),
            [nameof(FClassPtrProperty)] = typeof(FClassPtrProperty),
            [nameof(FDelegateProperty)] = typeof(FDelegateProperty),
            [nameof(FDoubleProperty)] = typeof(FDoubleProperty),
            [nameof(FEnumProperty)] = typeof(FEnumProperty),
            [nameof(FFieldPathProperty)] = typeof(FFieldPathProperty),
            [nameof(FFloatProperty)] = typeof(FFloatProperty),
            [nameof(FInt16Property)] = typeof(FInt16Property),
            [nameof(FInt64Property)] = typeof(FInt64Property),
            [nameof(FInt8Property)] = typeof(FInt8Property),
            [nameof(FInterfaceProperty)] = typeof(FInterfaceProperty),
            [nameof(FIntProperty)] = typeof(FIntProperty),
            [nameof(FLazyObjectProperty)] = typeof(FLazyObjectProperty),
            [nameof(FMapProperty)] = typeof(FMapProperty),
            [nameof(FMulticastDelegateProperty)] = typeof(FMulticastDelegateProperty),
            [nameof(FMulticastInlineDelegateProperty)] = typeof(FMulticastInlineDelegateProperty),
            [nameof(FMulticastSparseDelegateProperty)] = typeof(FMulticastSparseDelegateProperty),
            [nameof(FNameProperty)] = typeof(FNameProperty),
            [nameof(FNumericProperty)] = typeof(FNumericProperty),
            [nameof(FObjectProperty)] = typeof(FObjectProperty),
            [nameof(FObjectPropertyBase)] = typeof(FObjectPropertyBase),
            [nameof(FObjectPtrProperty)] = typeof(FObjectPtrProperty),
            [nameof(FOptionalProperty)] = typeof(FOptionalProperty),
            [nameof(FSetProperty)] = typeof(FSetProperty),
            [nameof(FSoftClassProperty)] = typeof(FSoftClassProperty),
            [nameof(FSoftObjectProperty)] = typeof(FSoftObjectProperty),
            [nameof(FStrProperty)] = typeof(FStrProperty),
            [nameof(FStructProperty)] = typeof(FStructProperty),
            [nameof(FTextProperty)] = typeof(FTextProperty),
            [nameof(FUInt16Property)] = typeof(FUInt16Property),
            [nameof(FUInt32Property)] = typeof(FUInt32Property),
            [nameof(FUInt64Property)] = typeof(FUInt64Property),
            [nameof(FWeakObjectProperty)] = typeof(FWeakObjectProperty),
        });

        public static readonly ImmutableDictionary<string, Type> PropertyTypesByPrefix = ImmutableDictionary.CreateRange(new Dictionary<string, Type>
        {
            ["prop-array"] = typeof(FArrayProperty),
            ["prop-bool"] = typeof(FBoolProperty),
            ["prop-byte"] = typeof(FByteProperty),
            ["prop-class"] = typeof(FClassProperty),
            ["prop-classptr"] = typeof(FClassPtrProperty),
            ["prop-delegate"] = typeof(FDelegateProperty),
            ["prop-double"] = typeof(FDoubleProperty),
            ["prop-enum"] = typeof(FEnumProperty),
            ["prop-fieldpath"] = typeof(FFieldPathProperty),
            ["prop-float"] = typeof(FFloatProperty),
            ["prop-int16"] = typeof(FInt16Property),
            ["prop-int64"] = typeof(FInt64Property),
            ["prop-int8"] = typeof(FInt8Property),
            ["prop-interface"] = typeof(FInterfaceProperty),
            ["prop-int"] = typeof(FIntProperty),
            ["prop-lazyobject"] = typeof(FLazyObjectProperty),
            ["prop-map"] = typeof(FMapProperty),
            ["prop-multicast-delegate"] = typeof(FMulticastDelegateProperty),
            ["prop-multicast-sparse-delegate"] = typeof(FMulticastSparseDelegateProperty),
            ["prop-name"] = typeof(FNameProperty),
            ["prop-numeric"] = typeof(FNumericProperty),
            ["prop-object"] = typeof(FObjectProperty),
            ["prop-object-base"] = typeof(FObjectPropertyBase),
            ["prop-objectptr"] = typeof(FObjectPtrProperty),
            ["prop-optional"] = typeof(FOptionalProperty),
            ["prop-set"] = typeof(FSetProperty),
            ["prop-softclass"] = typeof(FSoftClassProperty),
            ["prop-softobject"] = typeof(FSoftObjectProperty),
            ["prop-str"] = typeof(FStrProperty),
            ["prop-struct"] = typeof(FStructProperty),
            ["prop-text"] = typeof(FTextProperty),
            ["prop-uint16"] = typeof(FUInt16Property),
            ["prop-uint32"] = typeof(FUInt32Property),
            ["prop-uint64"] = typeof(FUInt64Property),
            ["prop-weakobject"] = typeof(FWeakObjectProperty),
            ["prop-multicast-inline-delegate"] = typeof(FMulticastInlineDelegateProperty),
        });

        static FFieldClass()
        {
            NameToFieldClassMap[FArrayProperty.TYPE_NAME] = () => new FArrayProperty();
            NameToFieldClassMap[FBoolProperty.TYPE_NAME] = () => new FBoolProperty();
            NameToFieldClassMap[FByteProperty.TYPE_NAME] = () => new FByteProperty();
            NameToFieldClassMap[FClassProperty.TYPE_NAME] = () => new FClassProperty();
            NameToFieldClassMap[FClassPtrProperty.TYPE_NAME] = () => new FClassPtrProperty();
            NameToFieldClassMap[FDelegateProperty.TYPE_NAME] = () => new FDelegateProperty();
            NameToFieldClassMap[FDoubleProperty.TYPE_NAME] = () => new FDoubleProperty();
            NameToFieldClassMap[FEnumProperty.TYPE_NAME] = () => new FEnumProperty();
            NameToFieldClassMap[FFieldPathProperty.TYPE_NAME] = () => new FFieldPathProperty();
            NameToFieldClassMap[FFloatProperty.TYPE_NAME] = () => new FFloatProperty();
            NameToFieldClassMap[FInt16Property.TYPE_NAME] = () => new FInt16Property();
            NameToFieldClassMap[FInt64Property.TYPE_NAME] = () => new FInt64Property();
            NameToFieldClassMap[FInt8Property.TYPE_NAME] = () => new FInt8Property();
            NameToFieldClassMap[FInterfaceProperty.TYPE_NAME] = () => new FInterfaceProperty();
            NameToFieldClassMap[FIntProperty.TYPE_NAME] = () => new FIntProperty();
            NameToFieldClassMap[FLazyObjectProperty.TYPE_NAME] = () => new FLazyObjectProperty();
            NameToFieldClassMap[FMapProperty.TYPE_NAME] = () => new FMapProperty();
            NameToFieldClassMap[FMulticastDelegateProperty.TYPE_NAME] = () => new FMulticastDelegateProperty();
            NameToFieldClassMap[FMulticastInlineDelegateProperty.TYPE_NAME] = () => new FMulticastInlineDelegateProperty();
            NameToFieldClassMap[FMulticastSparseDelegateProperty.TYPE_NAME] = () => new FMulticastSparseDelegateProperty();
            NameToFieldClassMap[FNameProperty.TYPE_NAME] = () => new FNameProperty();
            NameToFieldClassMap[FNumericProperty.TYPE_NAME] = () => new FNumericProperty();
            NameToFieldClassMap[FObjectProperty.TYPE_NAME] = () => new FObjectProperty();
            NameToFieldClassMap[FObjectPropertyBase.TYPE_NAME] = () => new FObjectPropertyBase();
            NameToFieldClassMap[FObjectPtrProperty.TYPE_NAME] = () => new FObjectPtrProperty();
            NameToFieldClassMap[FProperty.TYPE_NAME] = () => new FProperty();
            NameToFieldClassMap[FSetProperty.TYPE_NAME] = () => new FSetProperty();
            NameToFieldClassMap[FSoftClassProperty.TYPE_NAME] = () => new FSoftClassProperty();
            NameToFieldClassMap[FSoftObjectProperty.TYPE_NAME] = () => new FSoftObjectProperty();
            NameToFieldClassMap[FSoftObjectProperty.OLD_TYPE_NAME] = () => new FSoftObjectProperty();
            NameToFieldClassMap[FStrProperty.TYPE_NAME] = () => new FStrProperty();
            NameToFieldClassMap[FStructProperty.TYPE_NAME] = () => new FStructProperty();
            NameToFieldClassMap[FTextProperty.TYPE_NAME] = () => new FTextProperty();
            NameToFieldClassMap[FUInt16Property.TYPE_NAME] = () => new FUInt16Property();
            NameToFieldClassMap[FUInt32Property.TYPE_NAME] = () => new FUInt32Property();
            NameToFieldClassMap[FUInt64Property.TYPE_NAME] = () => new FUInt64Property();
            NameToFieldClassMap[FWeakObjectProperty.TYPE_NAME] = () => new FWeakObjectProperty();
        }

        [Location("TMap<FName, FFieldClass*>& FFieldClass::GetNameToFieldClassMap()")]
        public static Dictionary<string, Func<FField>> GetNameToFieldClassMap()
        {
            return NameToFieldClassMap;
        }
    }
}
