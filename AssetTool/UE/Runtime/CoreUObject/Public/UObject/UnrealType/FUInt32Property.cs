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
    }

    public class FUInt32PropertySerializer : FPropertySerializerBase<FUInt32Property>
    {
        public FUInt32Property Read(JsonElement root, JsonSerializerOptions options)
        {
            var obj = ReadBaseProperties(root);
            obj.ElementSize = 4;
            return obj;
        }

        public void Write(Utf8JsonWriter writer, FUInt32Property value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            WriteBaseProperties(writer, value);
            writer.WriteEndObject();
        }
    }
}
