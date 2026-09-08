using System.Text.Json;

namespace AssetTool
{
    public class FClassPtrProperty : FClassProperty
    {
        public new const string TYPE_NAME = "ClassPtrProperty";
        public override string TypeName => TYPE_NAME;

        [Location("void FClassPtrProperty::SerializeItem(FStructuredArchive::FSlot Slot, void* Value, void const* Defaults) const")]
        public override FField Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    public class FClassPtrPropertySerializer : FPropertySerializerBase<FClassPtrProperty>
    {
        public FClassPtrProperty Read(JsonElement root, JsonSerializerOptions options)
        {
            var obj = ReadBaseProperties(root);
            obj.ElementSize = 8;
            obj.Value = FObjectPtr.FromString(root.GetProperty("Value").GetString());
            obj.MetaClass = root.GetProperty("MetaClass").GetUInt32();
            return obj;
        }

        public void Write(Utf8JsonWriter writer, FClassPtrProperty value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            WriteBaseProperties(writer, value);
            writer.WriteString("Value", value.Value.ToString());
            writer.WriteNumber("MetaClass", value.MetaClass);
            writer.WriteEndObject();
        }
    }
}
