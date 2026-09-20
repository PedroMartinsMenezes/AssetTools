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

        public override FProperty Read(JsonElement root, JsonSerializerOptions options)
        {
            string key = root.EnumerateObject().First().Name;

            JsonElement value = root.EnumerateObject().First().Value;

            var obj = ReadKeyValue<FStrProperty>(key, value);

            obj.ElementSize = key.GetNonNull("ElementSize({0})", x => int.Parse(x), 0);

            return obj;
        }

        public override void Write(Utf8JsonWriter writer, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            Dictionary<string, object> inlineFields = new()
            {
                ["ElementSize"] = this.ElementSize
            };

            WriteKeyValue(writer, options, this, "prop-str", inlineFields);

            writer.WriteEndObject();
        }
    }
}
