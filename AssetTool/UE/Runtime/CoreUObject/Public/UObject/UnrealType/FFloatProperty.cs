using System.Text.Json;

namespace AssetTool
{
    public class FFloatProperty : FNumericProperty
    {
        public new const string TYPE_NAME = "FloatProperty";
        public override string TypeName => TYPE_NAME;

        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }

        [Location("Slot << *TTypeFundamentals::GetPropertyValuePtr(Value);")]
        public static float MoveValue(Transfer transfer, float value)
        {
            transfer.Move(ref value);
            return value;
        }
    }

    public class FFloatPropertySerializer : FPropertySerializerBase<FFloatProperty>
    {
        public FFloatProperty Read(JsonElement root, JsonSerializerOptions options)
        {
            string key = root.EnumerateObject().First().Name;

            JsonElement value = root.EnumerateObject().First().Value;

            var obj = ReadKeyValue(key, value);

            obj.ElementSize = 4;

            return obj;
        }

        public void Write(Utf8JsonWriter writer, FFloatProperty value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            WriteKeyValue(writer, options, value, "prop-float");

            writer.WriteEndObject();
        }
    }
}
