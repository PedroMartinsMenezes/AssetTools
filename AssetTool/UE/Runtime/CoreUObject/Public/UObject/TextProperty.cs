using System.Text.Json;

namespace AssetTool
{
    public class FTextProperty : FProperty
    {
        public new const string TYPE_NAME = "TextProperty";
        public override string TypeName => TYPE_NAME;

        [Location("void FTextProperty::SerializeItem(FStructuredArchive::FSlot Slot, void* Value, void const* Defaults) const")]
        public static FText MoveValue(Transfer transfer, FText value)
        {
            transfer.Move(ref value);
            return value;
        }

        public override FProperty Read(JsonElement root, JsonSerializerOptions options)
        {
            string key = root.EnumerateObject().First().Name;

            JsonElement value = root.EnumerateObject().First().Value;

            var obj = ReadKeyValue<FTextProperty>(key, value);

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

            WriteKeyValue(writer, options, this, "prop-text", inlineFields);

            writer.WriteEndObject();
        }
    }
}
