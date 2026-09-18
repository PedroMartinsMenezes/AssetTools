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
    }

    public class FNamePropertySerializer : FPropertySerializerBase<FNameProperty>
    {
        public FNameProperty Read(JsonElement root, JsonSerializerOptions options)
        {
            string key = root.EnumerateObject().First().Name;

            JsonElement value = root.EnumerateObject().First().Value;

            var obj = ReadKeyValue(key, value);

            obj.ElementSize = 12;

            return obj;
        }

        public void Write(Utf8JsonWriter writer, FNameProperty value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            WriteKeyValue(writer, options, value, "prop-name");

            writer.WriteEndObject();
        }
    }
}
