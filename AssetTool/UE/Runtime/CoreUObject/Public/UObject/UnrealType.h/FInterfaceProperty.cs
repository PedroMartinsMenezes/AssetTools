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

        public override FProperty Read(JsonProperty elem, JsonSerializerOptions options)
        {
            string key = elem.Name;

            JsonElement value = elem.Value;

            var obj = ReadKeyValue<FInterfaceProperty>(key, value);

            obj.ElementSize = 16;

            obj.Value = key.GetNonNull("Value({0})", x => uint.Parse(x), (uint)0);

            return obj;
        }

        public override void Write(Utf8JsonWriter writer, JsonSerializerOptions options)
        {
            Dictionary<string, object> inlineFields = new()
            {
                ["Value"] = this.Value
            };

            WriteKeyValue(writer, options, this, "prop-interface", inlineFields);
        }
    }
}
