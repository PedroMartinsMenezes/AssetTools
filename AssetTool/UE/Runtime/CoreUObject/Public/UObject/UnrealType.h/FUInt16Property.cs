using System.Text.Json;

namespace AssetTool
{
    public class FUInt16Property : FNumericProperty
    {
        public new const string TYPE_NAME = "UInt16Property";
        public override string TypeName => TYPE_NAME;

        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }

        [Location("Slot << *TTypeFundamentals::GetPropertyValuePtr(Value);")]
        public static UInt16 MoveValue(Transfer transfer, UInt16 value)
        {
            transfer.Move(ref value);
            return value;
        }

        public override FProperty Read(JsonProperty elem, JsonSerializerOptions options)
        {
            string key = elem.Name;

            JsonElement value = elem.Value;

            var obj = ReadKeyValue<FUInt16Property>(key, value);

            obj.ElementSize = 2;

            return obj;
        }

        public override void Write(Utf8JsonWriter writer, JsonSerializerOptions options)
        {
            WriteKeyValue(writer, options, this, "prop-uint16");
        }
    }
}
