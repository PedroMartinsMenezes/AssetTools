using System.Text.Json;

namespace AssetTool
{
    public class FInt16Property : FNumericProperty
    {
        public new const string TYPE_NAME = "Int16Property";
        public override string TypeName => TYPE_NAME;

        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }

        [Location("Slot << *TTypeFundamentals::GetPropertyValuePtr(Value);")]
        public static Int16 MoveValue(Transfer transfer, Int16 value)
        {
            transfer.Move(ref value);
            return value;
        }

        public override FProperty Read(JsonElement root, JsonSerializerOptions options)
        {
            string key = root.EnumerateObject().First().Name;

            JsonElement value = root.EnumerateObject().First().Value;

            var obj = ReadKeyValue<FInt16Property>(key, value);

            obj.ElementSize = 2;

            return obj;
        }

        public override void Write(Utf8JsonWriter writer, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            WriteKeyValue(writer, options, this, "prop-int16");

            writer.WriteEndObject();
        }
    }
}
