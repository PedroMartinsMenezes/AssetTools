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
            obj.MetaClass = 4294967290;
            obj.ElementSize = 8;
            if (root.TryGetProperty("Value", out var value))
                obj.Value = FObjectPtr.FromString(value.GetString());
            if (root.TryGetProperty("MetaClass", out var metaclass))
                obj.MetaClass = metaclass.GetUInt32();
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
