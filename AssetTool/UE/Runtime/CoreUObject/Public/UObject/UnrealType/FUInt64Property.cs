using System.Text.Json;

namespace AssetTool
{
    public class FUInt64Property : FNumericProperty
    {
        public new const string TYPE_NAME = "UInt64Property";
        public override string TypeName => TYPE_NAME;

        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }

        [Location("Slot << *TTypeFundamentals::GetPropertyValuePtr(Value);")]
        public static UInt64 MoveValue(Transfer transfer, UInt64 value)
        {
            transfer.Move(ref value);
            return value;
        }
    }

    public class FUInt64PropertySerializer : FPropertySerializerBase<FUInt64Property>
    {
        public FUInt64Property Read(JsonElement root, JsonSerializerOptions options)
        {
            string key = root.EnumerateObject().First().Name;

            JsonElement value = root.EnumerateObject().First().Value;

            var obj = ReadKeyValue(key, value);

            obj.ElementSize = 8;

            return obj;
        }

        public void Write(Utf8JsonWriter writer, FUInt64Property value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            WriteKeyValue(writer, options, value, "prop-uint64");

            writer.WriteEndObject();
        }
    }
}
