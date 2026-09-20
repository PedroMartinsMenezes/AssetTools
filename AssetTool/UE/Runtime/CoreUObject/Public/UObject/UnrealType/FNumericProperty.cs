using System.Text.Json;

namespace AssetTool
{
    public class FNumericProperty : FProperty
    {
        public new const string TYPE_NAME = "NumericProperty";

        [Location("void FNumericProperty::Serialize(FArchive& Ar)")]
        public override FField Move(Transfer transfer)
        {
            return base.Move(transfer);
        }

        public override FProperty Read(JsonElement root, JsonSerializerOptions options)
        {
            string key = root.EnumerateObject().First().Name;

            JsonElement value = root.EnumerateObject().First().Value;

            var obj = ReadKeyValue<FNumericProperty>(key, value);

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

            WriteKeyValue(writer, options, this, "prop-numeric", inlineFields);

            writer.WriteEndObject();
        }
    }
}
