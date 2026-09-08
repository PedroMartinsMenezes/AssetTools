using System.Text.Json;

namespace AssetTool
{
    public class FLazyObjectProperty : FProperty
    {
        public new const string TYPE_NAME = "LazyObjectProperty";
        public override string TypeName => TYPE_NAME;

        public UInt32 Value;

        [Location("void FLazyObjectProperty::SerializeItem( FStructuredArchive::FSlot Slot, void* Value, void const* Defaults ) const")]
        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref Value);
            return this;
        }
    }

    public class FMulticastInlineDelegateProperty : FProperty
    {
        public new const string TYPE_NAME = "MulticastInlineDelegateProperty";
        public override string TypeName => TYPE_NAME;

        public UInt32 PropertyValuePtr;
        public List<TScriptDelegate> InvocationList;

        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref PropertyValuePtr);
            return this;
        }

        [Location("void FMulticastInlineDelegateProperty::SerializeItem(FStructuredArchive::FSlot Slot, void* Value, void const* Defaults) const")]
        public FField SerializeItem(Transfer transfer)
        {
            transfer.Move(ref InvocationList);
            return this;
        }
    }

    public class FMulticastInlineDelegatePropertySerializer : FPropertySerializerBase<FMulticastInlineDelegateProperty>
    {
        public FMulticastInlineDelegateProperty Read(JsonElement root, JsonSerializerOptions options)
        {
            var obj = ReadBaseProperties(root);
            obj.ElementSize = root.GetProperty("ElementSize").GetInt32();
            obj.PropertyValuePtr = root.GetProperty("PropertyValuePtr").GetUInt32();
            if (root.TryGetProperty("InvocationList", out var invocationListProperty) && invocationListProperty.ValueKind == JsonValueKind.Array)
            {
                obj.InvocationList = JsonSerializer.Deserialize<List<TScriptDelegate>>(invocationListProperty.GetRawText(), options);
            }
            return obj;
        }

        public void Write(Utf8JsonWriter writer, FMulticastInlineDelegateProperty value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            WriteBaseProperties(writer, value);
            writer.WriteNumber("ElementSize", value.ElementSize);
            writer.WriteNumber("PropertyValuePtr", value.PropertyValuePtr);
            if (value.InvocationList is { })
            {
                writer.WritePropertyName("InvocationList");
                writer.WriteStartArray();
                JsonSerializer.Serialize(writer, value.InvocationList, options);
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
    }
}
