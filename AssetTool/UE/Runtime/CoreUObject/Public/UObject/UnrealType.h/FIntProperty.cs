using System.Text.Json;

namespace AssetTool
{
    public class FIntProperty : FNumericProperty
    {
        public new const string TYPE_NAME = "IntProperty";
        public override string TypeName => TYPE_NAME;

        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }

        [Location("FArchive& FLinkerLoad::operator<<(FObjectPtr& ObjectPtr)")]
        public static int MoveValue(Transfer transfer, int value)
        {
            transfer.Move(ref value);
            return value;
        }

        public override FProperty Read(JsonProperty elem, JsonSerializerOptions options)
        {
            string key = elem.Name;

            JsonElement value = elem.Value;

            var obj = ReadKeyValue<FIntProperty>(key, value);

            obj.ElementSize = 4;

            return obj;
        }

        public override void Write(Utf8JsonWriter writer, JsonSerializerOptions options)
        {
            WriteKeyValue(writer, options, this, "prop-int");
        }
    }
}
