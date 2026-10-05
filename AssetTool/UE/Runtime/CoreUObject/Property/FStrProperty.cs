using System.Text.Json;

namespace AssetTool
{
    public class FStrProperty : FProperty
    {
        public new const string TYPE_NAME = "StrProperty";
        public override string TypeName => TYPE_NAME;

        [Location("Slot << *TTypeFundamentals::GetPropertyValuePtr(Value);")]
        public static FString MoveValue(Transfer transfer, FString value)
        {
            transfer.Move(ref value);
            return value;
        }

        public override FProperty Read(JsonProperty elem, JsonSerializerOptions options)
        {
            string key = elem.Name;

            JsonElement value = elem.Value;

            var obj = ReadKeyValue<FStrProperty>(key, value);

            obj.ElementSize = key.GetNonNull("ElementSize({0})", x => int.Parse(x), 0);

            return obj;
        }

        public override void Write(Utf8JsonWriter writer, JsonSerializerOptions options)
        {
            Dictionary<string, object> inlineFields = new()
            {
                ["ElementSize"] = this.ElementSize
            };

            WriteKeyValue(writer, options, this, "prop-str", inlineFields);
        }
    }
}
