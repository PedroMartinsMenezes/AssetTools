using System.Text.Json;

namespace AssetTool
{
    public class FInt64Property : FNumericProperty
    {
        public new const string TYPE_NAME = "Int64Property";
        public override string TypeName => TYPE_NAME;

        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }

        [Location("Slot << *TTypeFundamentals::GetPropertyValuePtr(Value);")]
        public static Int64 MoveValue(Transfer transfer, Int64 value)
        {
            transfer.Move(ref value);
            return value;
        }
    }

    public class FInt64PropertySerializer : FPropertySerializerBase<FInt64Property>
    {
        public FInt64Property Read(JsonElement root, JsonSerializerOptions options)
        {
            string key = root.EnumerateObject().First().Name;

            JsonElement value = root.EnumerateObject().First().Value;

            var obj = ReadKeyValue(key, value);

            obj.ElementSize = 8;

            return obj;
        }

        public void Write(Utf8JsonWriter writer, FInt64Property value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            WriteKeyValue(writer, options, value, "prop-int64");

            writer.WriteEndObject();
        }
    }
}
