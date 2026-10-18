using System.Text.Json;

namespace AssetTool
{
    public class FNameProperty : FProperty
    {
        public new const string TYPE_NAME = "NameProperty";
        public override string TypeName => TYPE_NAME;

        [Location("Slot << *TTypeFundamentals::GetPropertyValuePtr(Value);")]
        public static FName MoveValue(Transfer transfer, FName value)
        {
            transfer.Move(ref value);
            return value;
        }

        public override FProperty Read(JsonProperty elem, JsonSerializerOptions options)
        {
            string key = elem.Name;

            JsonElement value = elem.Value;

            var obj = ReadKeyValue<FNameProperty>(key, value);

            obj.ElementSize = 12;

            return obj;
        }

        public override void Write(Utf8JsonWriter writer, JsonSerializerOptions options)
        {
            WriteKeyValue(writer, options, this, "prop-name");
        }
    }
}
