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
    }

    public class FTextPropertySerializer : FPropertySerializerBase<FTextProperty>
    {
        public FTextProperty Read(JsonElement root, JsonSerializerOptions options)
        {
            string key = root.EnumerateObject().First().Name;

            JsonElement value = root.EnumerateObject().First().Value;

            var obj = ReadKeyValue(key, value);

            obj.ElementSize = key.GetNonNull("ElementSize({0})", x => int.Parse(x), 0);

            return obj;
        }

        public void Write(Utf8JsonWriter writer, FTextProperty value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            Dictionary<string, object> inlineFields = new()
            {
                ["ElementSize"] = value.ElementSize
            };

            WriteKeyValue(writer, options, value, "prop-text", inlineFields);

            writer.WriteEndObject();
        }
    }
}
