using System.Text.Json;

namespace AssetTool
{
    [BaseEngineIni("+ClassRedirects=(OldName=\"AssetObjectProperty\",NewName=\"/Script/CoreUObject.SoftObjectProperty\")")]
    public class FSoftObjectProperty : FProperty
    {
        public new const string TYPE_NAME = "SoftObjectProperty";
        public const string OLD_TYPE_NAME = "AssetObjectProperty";
        public override string TypeName => TYPE_NAME;

        public UInt32 Value;
        public FSoftObjectPtr Ptr;

        [Location("void FSoftObjectProperty::SerializeItem( FStructuredArchive::FSlot Slot, void* Value, void const* Defaults ) const")]
        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref Value);
            return this;
        }

        [Location("EConvertFromTypeResult FObjectProperty::ConvertFromType(const FPropertyTag& Tag, FStructuredArchive::FSlot Slot, uint8* Data, UStruct* DefaultsStruct, const uint8* Defaults)")]
        public FField ConvertFromType(Transfer transfer)
        {
            transfer.Move(ref Ptr);
            return this;
        }

        public static FSoftObjectPtr MoveValue(Transfer transfer, FSoftObjectPtr value)
        {
            transfer.Move(ref value);
            return value;
        }

        public override FProperty Read(JsonElement root, JsonSerializerOptions options)
        {
            string key = root.EnumerateObject().First().Name;

            JsonElement value = root.EnumerateObject().First().Value;

            var obj = ReadKeyValue<FSoftObjectProperty>(key, value);

            obj.ElementSize = key.GetNonNull("ElementSize({0})", x => int.Parse(x), 0);

            obj.Value = key.GetNonNull("Value({0})", x => uint.Parse(x), (uint)0);

            return obj;
        }

        public override void Write(Utf8JsonWriter writer, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            Dictionary<string, object> inlineFields = new()
            {
                ["ElementSize"] = this.ElementSize,
                ["Value"] = this.Value
            };

            WriteKeyValue(writer, options, this, "prop-softobject", inlineFields);

            writer.WriteEndObject();
        }
    }
}
