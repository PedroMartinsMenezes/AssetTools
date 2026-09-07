using System.Text.Json;

namespace AssetTool
{
    public class FObjectProperty : FProperty
    {
        public new const string TYPE_NAME = "ObjectProperty";
        public override string TypeName => TYPE_NAME;

        public FObjectPtr Value;

        [Location("void FObjectPropertyBase::Serialize( FArchive& Ar )")]
        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref Value);
            return this;
        }

        public static Int32 MoveValue(Transfer transfer, Int32 value)
        {
            transfer.Move(ref value);
            return value;
        }
    }

    public class FObjectPropertySerializer : FPropertySerializerBase<FObjectProperty>
    {
        public FObjectProperty Read(JsonElement root, JsonSerializerOptions options)
        {
            var value = ReadBaseProperties(root);
            value.ElementSize = 8;
            ReadValue(root, value);
            return value;
        }

        public void Write(Utf8JsonWriter writer, FObjectProperty value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            WriteBaseProperties(writer, value);
            writer.WriteEndObject();
        }

        protected override void ReadValue(JsonElement root, FObjectProperty value)
        {
            if (root.TryGetProperty("Value", out var valueProperty))
                value.Value = FObjectPtr.FromString(valueProperty.GetString());
        }

        protected override void WriteValue(Utf8JsonWriter writer, FObjectProperty value)
        {
            writer.WriteString("Value", value.Value.ToString());
        }
    }
}
