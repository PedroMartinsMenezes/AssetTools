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
            var value = ReadBaseProperties(root);
            value.ElementSize = 4;
            ReadValue(root, value);
            return value;
        }

        public void Write(Utf8JsonWriter writer, FFloatProperty value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            WriteBaseProperties(writer, value);
            writer.WriteEndObject();
        }
    }
}
