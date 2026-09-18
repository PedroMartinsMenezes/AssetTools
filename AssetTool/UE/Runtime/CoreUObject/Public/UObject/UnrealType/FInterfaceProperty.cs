using System.Text.Json;

namespace AssetTool
{
    public class FInterfaceProperty : FProperty
    {
        public new const string TYPE_NAME = "InterfaceProperty";
        public override string TypeName => TYPE_NAME;

        public UInt32 Value;

        [Location("void FInterfaceProperty::Serialize( FArchive& Ar )")]
        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref Value);
            return this;
        }

        [Location("EConvertFromTypeResult FObjectProperty::ConvertFromType(const FPropertyTag& Tag, FStructuredArchive::FSlot Slot, uint8* Data, UStruct* DefaultsStruct, const uint8* Defaults)")]
        public FField ConvertFromType(Transfer transfer)
        {
            transfer.Move(ref Value);
            return this;
        }
    }

    public class FInterfacePropertySerializer : FPropertySerializerBase<FInterfaceProperty>
    {
        public FInterfaceProperty Read(JsonElement root, JsonSerializerOptions options)
        {
            string key = root.EnumerateObject().First().Name;

            JsonElement value = root.EnumerateObject().First().Value;

            var obj = ReadKeyValue(key, value);

            obj.ElementSize = 16;

            obj.Value = key.GetNonNull("Value({0})", x => uint.Parse(x), (uint)0);

            return obj;
        }

        public void Write(Utf8JsonWriter writer, FInterfaceProperty value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            Dictionary<string, object> inlineFields = new()
            {
                ["Value"] = value.Value
            };

            WriteKeyValue(writer, options, value, "prop-interface", inlineFields);

            writer.WriteEndObject();
        }
    }
}
