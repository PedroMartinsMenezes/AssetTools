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
            string key = root.EnumerateObject().First().Name;

            JsonElement value = root.EnumerateObject().First().Value;

            var obj = ReadKeyValue(key, value);

            obj.ElementSize = 1;

            obj.Value = key.GetNonNull("Value({0})", x => uint.Parse(x), (uint)0);

            return obj;
        }

        public void Write(Utf8JsonWriter writer, FByteProperty value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            Dictionary<string, object> inlineFields = new();

            inlineFields.Add("Value", value.Value);

            WriteKeyValue(writer, options, value, "prop-byte", inlineFields);

            writer.WriteEndObject();
        }
    }
}
