using System.Text.Json;

namespace AssetTool
{
    public class FInt8Property : FNumericProperty
    {
        public new const string TYPE_NAME = "Int8Property";
        public override string TypeName => TYPE_NAME;

        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }

        [Location("Slot << *TTypeFundamentals::GetPropertyValuePtr(Value);")]
        public static sbyte MoveValue(Transfer transfer, sbyte value)
        {
            transfer.Move(ref value);
            return value;
        }
    }

    public class FInt8PropertySerializer : FPropertySerializerBase<FInt8Property>
    {
        public FInt8Property Read(JsonElement root, JsonSerializerOptions options)
        {
            var obj = ReadBaseProperties(root);
            obj.ElementSize = 1;
            return obj;
        }

        public void Write(Utf8JsonWriter writer, FInt8Property value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            WriteBaseProperties(writer, value);
            writer.WriteEndObject();
        }
    }
}
