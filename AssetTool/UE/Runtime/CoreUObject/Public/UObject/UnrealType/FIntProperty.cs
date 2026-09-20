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

        public override FProperty Read(JsonElement root, JsonSerializerOptions options)
        {
            string key = root.EnumerateObject().First().Name;

            JsonElement value = root.EnumerateObject().First().Value;

            var obj = ReadKeyValue<FIntProperty>(key, value);

            obj.ElementSize = 4;

            return obj;
        }

        public override void Write(Utf8JsonWriter writer, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            WriteKeyValue(writer, options, this, "prop-int");

            writer.WriteEndObject();
        }
    }
}
