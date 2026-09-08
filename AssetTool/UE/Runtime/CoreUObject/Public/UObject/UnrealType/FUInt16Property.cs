using System.Text.Json;

namespace AssetTool
{
    public class FUInt16Property : FNumericProperty
    {
        public new const string TYPE_NAME = "UInt16Property";
        public override string TypeName => TYPE_NAME;

        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }

        [Location("Slot << *TTypeFundamentals::GetPropertyValuePtr(Value);")]
        public static UInt16 MoveValue(Transfer transfer, UInt16 value)
        {
            transfer.Move(ref value);
            return value;
        }
    }

    public class FUInt16PropertySerializer : FPropertySerializerBase<FUInt16Property>
    {
        public FUInt16Property Read(JsonElement root, JsonSerializerOptions options)
        {
            var obj = ReadBaseProperties(root);
            obj.ElementSize = 2;
            return obj;
        }

        public void Write(Utf8JsonWriter writer, FUInt16Property value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            WriteBaseProperties(writer, value);
            writer.WriteEndObject();
        }
    }
}
