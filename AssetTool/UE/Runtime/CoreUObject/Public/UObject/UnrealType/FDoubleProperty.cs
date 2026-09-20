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

        public override FProperty Read(JsonElement root, JsonSerializerOptions options)
        {
            string key = root.EnumerateObject().First().Name;

            JsonElement value = root.EnumerateObject().First().Value;

            var obj = ReadKeyValue<FDoubleProperty>(key, value);

            obj.ElementSize = 8;

            return obj;
        }

        public override void Write(Utf8JsonWriter writer, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            WriteKeyValue(writer, options, this, "prop-double");

            writer.WriteEndObject();
        }
    }
}
