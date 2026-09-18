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
    }

    public class FInt16PropertySerializer : FPropertySerializerBase<FInt16Property>
    {
        public FInt16Property Read(JsonElement root, JsonSerializerOptions options)
        {
            string key = root.EnumerateObject().First().Name;

            JsonElement value = root.EnumerateObject().First().Value;

            var obj = ReadKeyValue(key, value);

            obj.ElementSize = 2;

            return obj;
        }

        public void Write(Utf8JsonWriter writer, FInt16Property value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            WriteKeyValue(writer, options, value, "prop-int16");

            writer.WriteEndObject();
        }
    }
}
