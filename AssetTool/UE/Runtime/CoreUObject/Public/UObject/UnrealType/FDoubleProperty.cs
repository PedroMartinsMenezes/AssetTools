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

        public override FProperty Read(JsonProperty elem, JsonSerializerOptions options)
        {
            string key = elem.Name;

            JsonElement value = elem.Value;

            var obj = ReadKeyValue<FDoubleProperty>(key, value);

            obj.ElementSize = 8;

            return obj;
        }

        public override void Write(Utf8JsonWriter writer, JsonSerializerOptions options)
        {
            WriteKeyValue(writer, options, this, "prop-double");
        }
    }
}
