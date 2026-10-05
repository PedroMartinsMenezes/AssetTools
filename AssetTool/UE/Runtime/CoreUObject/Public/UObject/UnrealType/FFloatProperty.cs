using System.Text.Json;

namespace AssetTool
{
    public class FFloatProperty : FNumericProperty
    {
        public new const string TYPE_NAME = "FloatProperty";
        public override string TypeName => TYPE_NAME;

        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }

        [Location("Slot << *TTypeFundamentals::GetPropertyValuePtr(Value);")]
        public static float MoveValue(Transfer transfer, float value)
        {
            transfer.Move(ref value);
            return value;
        }

        public override FProperty Read(JsonProperty elem, JsonSerializerOptions options)
        {
            string key = elem.Name;

            JsonElement value = elem.Value;

            var obj = ReadKeyValue<FFloatProperty>(key, value);

            obj.ElementSize = 4;

            return obj;
        }

        public override void Write(Utf8JsonWriter writer, JsonSerializerOptions options)
        {
            WriteKeyValue(writer, options, this, "prop-float");
        }
    }
}
