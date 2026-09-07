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
    }

    public sealed class FFieldJsonConverter : JsonConverter<FField>
    {
        public override FField Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using JsonDocument document = JsonDocument.ParseValue(ref reader);

            JsonElement root = document.RootElement;

            if (!root.TryGetProperty("__type", out JsonElement typeElement))
                throw new JsonException("Property '__type' not found.");

            string typeName = typeElement.GetString();

            return typeName switch
            {
                nameof(FIntProperty)
                    => FIntPropertySerializer.Read(root, options),
                nameof(FArrayProperty)
                    => JsonSerializer.Deserialize<FArrayProperty>(root.GetRawText(), options)!,
                nameof(FBoolProperty)
                    => JsonSerializer.Deserialize<FBoolProperty>(root.GetRawText(), options)!,
                nameof(FByteProperty)
                    => JsonSerializer.Deserialize<FByteProperty>(root.GetRawText(), options)!,
                nameof(FClassProperty)
                    => JsonSerializer.Deserialize<FClassProperty>(root.GetRawText(), options)!,
                nameof(FClassPtrProperty)
                    => JsonSerializer.Deserialize<FClassPtrProperty>(root.GetRawText(), options)!,
                nameof(FDelegateProperty)
                    => JsonSerializer.Deserialize<FDelegateProperty>(root.GetRawText(), options)!,
                nameof(FDoubleProperty)
                    => JsonSerializer.Deserialize<FDoubleProperty>(root.GetRawText(), options)!,
                nameof(FEnumProperty)
                    => JsonSerializer.Deserialize<FEnumProperty>(root.GetRawText(), options)!,
                nameof(FFieldPathProperty)
                    => JsonSerializer.Deserialize<FFieldPathProperty>(root.GetRawText(), options)!,
                nameof(FFloatProperty)
                    => JsonSerializer.Deserialize<FFloatProperty>(root.GetRawText(), options)!,
                nameof(FInt16Property)
                    => JsonSerializer.Deserialize<FInt16Property>(root.GetRawText(), options)!,
                nameof(FInt64Property)
                    => JsonSerializer.Deserialize<FInt64Property>(root.GetRawText(), options)!,
                nameof(FInt8Property)
                    => JsonSerializer.Deserialize<FInt8Property>(root.GetRawText(), options)!,
                nameof(FInterfaceProperty)
                    => JsonSerializer.Deserialize<FInterfaceProperty>(root.GetRawText(), options)!,
                nameof(FLazyObjectProperty)
                    => JsonSerializer.Deserialize<FLazyObjectProperty>(root.GetRawText(), options)!,
                nameof(FMapProperty)
                    => JsonSerializer.Deserialize<FMapProperty>(root.GetRawText(), options)!,
                nameof(FMulticastDelegateProperty)
                    => JsonSerializer.Deserialize<FMulticastDelegateProperty>(root.GetRawText(), options)!,
                nameof(FMulticastInlineDelegateProperty)
                    => JsonSerializer.Deserialize<FMulticastInlineDelegateProperty>(root.GetRawText(), options)!,
                nameof(FMulticastSparseDelegateProperty)
                    => JsonSerializer.Deserialize<FMulticastSparseDelegateProperty>(root.GetRawText(), options)!,
                nameof(FNameProperty)
                    => JsonSerializer.Deserialize<FNameProperty>(root.GetRawText(), options)!,
                nameof(FNumericProperty)
                    => JsonSerializer.Deserialize<FNumericProperty>(root.GetRawText(), options)!,
                nameof(FObjectProperty)
                    => JsonSerializer.Deserialize<FObjectProperty>(root.GetRawText(), options)!,
                nameof(FObjectPropertyBase)
                    => JsonSerializer.Deserialize<FObjectPropertyBase>(root.GetRawText(), options)!,
                nameof(FObjectPtrProperty)
                    => JsonSerializer.Deserialize<FObjectPtrProperty>(root.GetRawText(), options)!,
                nameof(FOptionalProperty)
                    => JsonSerializer.Deserialize<FOptionalProperty>(root.GetRawText(), options)!,
                nameof(FProperty)
                    => JsonSerializer.Deserialize<FProperty>(root.GetRawText(), options)!,
                nameof(FSetProperty)
                    => JsonSerializer.Deserialize<FSetProperty>(root.GetRawText(), options)!,
                nameof(FSoftClassProperty)
                    => JsonSerializer.Deserialize<FSoftClassProperty>(root.GetRawText(), options)!,
                nameof(FSoftObjectProperty)
                    => JsonSerializer.Deserialize<FSoftObjectProperty>(root.GetRawText(), options)!,
                nameof(FStrProperty)
                    => JsonSerializer.Deserialize<FStrProperty>(root.GetRawText(), options)!,
                nameof(FStructProperty)
                    => JsonSerializer.Deserialize<FStructProperty>(root.GetRawText(), options)!,
                nameof(FTextProperty)
                    => JsonSerializer.Deserialize<FTextProperty>(root.GetRawText(), options)!,
                nameof(FUInt16Property)
                    => JsonSerializer.Deserialize<FUInt16Property>(root.GetRawText(), options)!,
                nameof(FUInt32Property)
                    => JsonSerializer.Deserialize<FUInt32Property>(root.GetRawText(), options)!,
                nameof(FUInt64Property)
                    => JsonSerializer.Deserialize<FUInt64Property>(root.GetRawText(), options)!,
                nameof(FWeakObjectProperty)
                    => JsonSerializer.Deserialize<FWeakObjectProperty>(root.GetRawText(), options)!,
                _ => throw new JsonException(
                    $"Unknown field type '{typeName}'.")
            };
        }

        public override void Write(Utf8JsonWriter writer, FField value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case FIntProperty intProperty:
                    FIntPropertySerializer.Write(writer, intProperty, options);
                    return;

                default:
                    writer.WriteStartObject();

                    writer.WriteString("__type", value.GetType().Name);

                    JsonElement element = JsonSerializer.SerializeToElement(value, value.GetType(), options);

                    foreach (JsonProperty property in element.EnumerateObject())
                    {
                        property.WriteTo(writer);
                    }

                    writer.WriteEndObject();
                    return;
            }
        }
    }
}
