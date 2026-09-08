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
            string typeName = root.GetProperty("__type").GetString();

            return typeName switch
            {
                nameof(FClassProperty) => new FClassPropertySerializer().Read(root, options),
                nameof(FObjectProperty) => new FObjectPropertySerializer().Read(root, options),
                nameof(FFloatProperty) => new FFloatPropertySerializer().Read(root, options),
                nameof(FDoubleProperty) => new FDoublePropertySerializer().Read(root, options),
                nameof(FInt8Property) => new FInt8PropertySerializer().Read(root, options),
                nameof(FInt16Property) => new FInt16PropertySerializer().Read(root, options),
                nameof(FIntProperty) => new FIntPropertySerializer().Read(root, options),
                nameof(FInt64Property) => new FInt64PropertySerializer().Read(root, options),
                nameof(FByteProperty) => new FBytePropertySerializer().Read(root, options),
                nameof(FUInt16Property) => new FUInt16PropertySerializer().Read(root, options),
                nameof(FUInt32Property) => new FUInt32PropertySerializer().Read(root, options),
                nameof(FUInt64Property) => new FUInt64PropertySerializer().Read(root, options),
                nameof(FDelegateProperty) => new FDelegatePropertySerializer().Read(root, options),
                nameof(FMulticastInlineDelegateProperty) => new FMulticastInlineDelegatePropertySerializer().Read(root, options),
                nameof(FArrayProperty) => new FArrayPropertySerializer().Read(root, options),
                nameof(FBoolProperty) => new FBoolPropertySerializer().Read(root, options),
                //

                nameof(FClassPtrProperty)
                    => JsonSerializer.Deserialize<FClassPtrProperty>(root.GetRawText(), options)!,
                nameof(FEnumProperty)
                    => JsonSerializer.Deserialize<FEnumProperty>(root.GetRawText(), options)!,
                nameof(FFieldPathProperty)
                    => JsonSerializer.Deserialize<FFieldPathProperty>(root.GetRawText(), options)!,
                nameof(FInterfaceProperty)
                    => JsonSerializer.Deserialize<FInterfaceProperty>(root.GetRawText(), options)!,
                nameof(FLazyObjectProperty)
                    => JsonSerializer.Deserialize<FLazyObjectProperty>(root.GetRawText(), options)!,
                nameof(FMapProperty)
                    => JsonSerializer.Deserialize<FMapProperty>(root.GetRawText(), options)!,
                nameof(FMulticastDelegateProperty)
                    => JsonSerializer.Deserialize<FMulticastDelegateProperty>(root.GetRawText(), options)!,
                nameof(FMulticastSparseDelegateProperty)
                    => JsonSerializer.Deserialize<FMulticastSparseDelegateProperty>(root.GetRawText(), options)!,
                nameof(FNameProperty)
                    => JsonSerializer.Deserialize<FNameProperty>(root.GetRawText(), options)!,
                nameof(FNumericProperty)
                    => JsonSerializer.Deserialize<FNumericProperty>(root.GetRawText(), options)!,
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
                case FClassProperty classProperty: new FClassPropertySerializer().Write(writer, classProperty, options); return;
                case FObjectProperty objectProperty: new FObjectPropertySerializer().Write(writer, objectProperty, options); return;
                case FFloatProperty floatProperty: new FFloatPropertySerializer().Write(writer, floatProperty, options); return;
                case FDoubleProperty doubleProperty: new FDoublePropertySerializer().Write(writer, doubleProperty, options); return;
                case FInt8Property int8Property: new FInt8PropertySerializer().Write(writer, int8Property, options); return;
                case FInt16Property int16Property: new FInt16PropertySerializer().Write(writer, int16Property, options); return;
                case FIntProperty intProperty: new FIntPropertySerializer().Write(writer, intProperty, options); return;
                case FInt64Property int64Property: new FInt64PropertySerializer().Write(writer, int64Property, options); return;
                case FByteProperty byteProperty: new FBytePropertySerializer().Write(writer, byteProperty, options); return;
                case FUInt16Property uint16Property: new FUInt16PropertySerializer().Write(writer, uint16Property, options); return;
                case FUInt32Property uint32Property: new FUInt32PropertySerializer().Write(writer, uint32Property, options); return;
                case FUInt64Property uint64Property: new FUInt64PropertySerializer().Write(writer, uint64Property, options); return;
                case FDelegateProperty delegateProperty: new FDelegatePropertySerializer().Write(writer, delegateProperty, options); return;
                case FMulticastInlineDelegateProperty multicastInlineDelegateProperty: new FMulticastInlineDelegatePropertySerializer().Write(writer, multicastInlineDelegateProperty, options); return;
                case FArrayProperty arrayProperty: new FArrayPropertySerializer().Write(writer, arrayProperty, options); return;
                case FBoolProperty boolProperty: new FBoolPropertySerializer().Write(writer, boolProperty, options); return;

                default:
                    writer.WriteStartObject();
                    writer.WriteString("__type", value.GetType().Name);
                    JsonElement element = JsonSerializer.SerializeToElement(value, value.GetType(), options);
                    foreach (JsonProperty property in element.EnumerateObject())
                        property.WriteTo(writer);
                    writer.WriteEndObject();
                    return;
            }
        }
    }
}
