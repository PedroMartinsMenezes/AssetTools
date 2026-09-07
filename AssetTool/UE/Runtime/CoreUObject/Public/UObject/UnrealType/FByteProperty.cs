using System.Text.Json;

namespace AssetTool
{
    public class FByteProperty : FNumericProperty
    {
        public new const string TYPE_NAME = "ByteProperty";
        public override string TypeName => TYPE_NAME;
        public UInt32 Value;

        [Location("void FByteProperty::Serialize( FArchive& Ar )")]
        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref Value);
            return this;
        }

        [Location("void FByteProperty::SerializeItem( FStructuredArchive::FSlot Slot, void* Value, void const* Defaults ) const")]
        public static FName MoveValue(Transfer transfer, FName value)
        {
            transfer.Move(ref value);
            return value;
        }
    }

    public class FBytePropertySerializer : FPropertySerializerBase<FByteProperty>
    {
        public FByteProperty Read(JsonElement root, JsonSerializerOptions options)
        {
            var obj = ReadBaseProperties(root);
            obj.ElementSize = 1;
            if (root.TryGetProperty("Value", out var metaclass))
                obj.Value = metaclass.GetUInt32();
            return obj;
        }

        public void Write(Utf8JsonWriter writer, FByteProperty value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            WriteBaseProperties(writer, value);
            writer.WriteNumber("Value", value.Value);
            writer.WriteEndObject();
        }
    }
}
