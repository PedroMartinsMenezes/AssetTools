using System.Text.Json;

namespace AssetTool
{
    public class FClassProperty : FObjectProperty
    {
        public new const string TYPE_NAME = "ClassProperty";
        public override string TypeName => TYPE_NAME;

        public UInt32 MetaClass;

        [Location("void FClassProperty::Serialize( FArchive& Ar )")]
        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref MetaClass);
            return this;
        }
    }

    public class FClassPropertySerializer : FPropertySerializerBase<FClassProperty>
    {
        public FClassProperty Read(JsonElement root, JsonSerializerOptions options)
        {
            var obj = ReadBaseProperties(root);
            obj.ElementSize = 8;
            obj.Value = FObjectPtr.FromString(root.GetProperty("Value").GetString());
            obj.MetaClass = root.GetProperty("MetaClass").GetUInt32();
            return obj;
        }

        public void Write(Utf8JsonWriter writer, FClassProperty value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            WriteBaseProperties(writer, value);
            writer.WriteString("Value", value.Value.ToString());
            writer.WriteNumber("MetaClass", value.MetaClass);
            writer.WriteEndObject();
        }
    }
}
