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
    }

    public class FIntPropertySerializer : FPropertySerializerBase<FIntProperty>
    {
        public FIntProperty Read(JsonElement root, JsonSerializerOptions options)
        {
            var value = ReadBaseProperties(root);
            value.ElementSize = 4;
            ReadValue(root, value);
            return value;
        }

        public void Write(Utf8JsonWriter writer, FIntProperty value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            WriteBaseProperties(writer, value);
            writer.WriteEndObject();
        }
    }
}
