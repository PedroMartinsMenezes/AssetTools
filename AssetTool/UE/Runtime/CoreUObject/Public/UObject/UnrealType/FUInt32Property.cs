using System.Text.Json;

namespace AssetTool
{
    public class FUInt32Property : FNumericProperty
    {
        public new const string TYPE_NAME = "UInt32Property";
        public override string TypeName => TYPE_NAME;

        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }

        [Location("Slot << *TTypeFundamentals::GetPropertyValuePtr(Value);")]
        public static UInt32 MoveValue(Transfer transfer, UInt32 value)
        {
            transfer.Move(ref value);
            return value;
        }

        public override FProperty Read(JsonElement root, JsonSerializerOptions options)
        {
            string key = root.EnumerateObject().First().Name;

            JsonElement value = root.EnumerateObject().First().Value;

            var obj = ReadKeyValue<FUInt32Property>(key, value);

            obj.ElementSize = 4;

            return obj;
        }

        public override void Write(Utf8JsonWriter writer, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            WriteKeyValue(writer, options, this, "prop-uint32");

            writer.WriteEndObject();
        }
    }
}
