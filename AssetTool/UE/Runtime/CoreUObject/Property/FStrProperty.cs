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
    }

    public class FStrPropertySerializer : FPropertySerializerBase<FStrProperty>
    {
        public FStrProperty Read(JsonElement root, JsonSerializerOptions options)
        {
            string key = root.EnumerateObject().First().Name;

            JsonElement value = root.EnumerateObject().First().Value;

            var obj = ReadKeyValue(key, value);

            obj.ElementSize = key.GetNonNull("ElementSize({0})", x => int.Parse(x), 0);

            return obj;
        }

        public void Write(Utf8JsonWriter writer, FStrProperty value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            Dictionary<string, object> inlineFields = new()
            {
                ["ElementSize"] = value.ElementSize
            };

            WriteKeyValue(writer, options, value, "prop-str", inlineFields);

            writer.WriteEndObject();
        }
    }
}
