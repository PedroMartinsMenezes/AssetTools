using System.Text.Json;

namespace AssetTool
{
    public class FDoubleProperty : FNumericProperty
    {
        public new const string TYPE_NAME = "DoubleProperty";
        public override string TypeName => TYPE_NAME;

        public new FField Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }

        [Location("Slot << *TTypeFundamentals::GetPropertyValuePtr(Value);")]
        public static double MoveValue(Transfer transfer, double value)
        {
            transfer.Move(ref value);
            return value;
        }
    }

    public class FDoublePropertySerializer : FPropertySerializerBase<FDoubleProperty>
    {
        public FDoubleProperty Read(JsonElement root, JsonSerializerOptions options)
        {
            var value = ReadBaseProperties(root);
            value.ElementSize = 8;
            ReadValue(root, value);
            return value;
        }

        public void Write(Utf8JsonWriter writer, FDoubleProperty value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            WriteBaseProperties(writer, value);
            writer.WriteEndObject();
        }
    }
}
