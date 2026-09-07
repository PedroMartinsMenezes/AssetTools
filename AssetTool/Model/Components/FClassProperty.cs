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
            var value = ReadBaseProperties(root);
            value.MetaClass = 4294967290;
            value.ElementSize = 8;
            ReadValue(root, value);
            return value;
        }

        public void Write(Utf8JsonWriter writer, FClassProperty value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            WriteBaseProperties(writer, value);
            writer.WriteEndObject();
        }

        protected override void ReadValue(JsonElement root, FClassProperty value)
        {
            if (root.TryGetProperty("Value", out var valueProperty))
                value.Value = FObjectPtr.FromString(valueProperty.GetString());
        }

        protected override void WriteValue(Utf8JsonWriter writer, FClassProperty value)
        {
            writer.WriteString("Value", value.Value.ToString());
        }
    }
}
