using System.Text.Json;

namespace AssetTool
{
    public class FStructProperty : FProperty
    {
        public new const string TYPE_NAME = "StructProperty";
        public override string TypeName => TYPE_NAME;

        public FObjectPtr Value;

        [Location("void FStructProperty::Serialize( FArchive& Ar )")]
        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref Value);
            return this;
        }
    }

    public class FStructPropertyItem : ITransferable
    {
        public Dictionary<string, object> Value;

        public ITransferable Move(Transfer transfer)
        {
            Value = transfer.MoveTags(Value.ToObject<Dictionary<string, object>>(transfer), 0);
            return this;
        }
    }

    public class FStructPropertySerializer : FPropertySerializerBase<FStructProperty>
    {
        public FStructProperty Read(JsonElement root, JsonSerializerOptions options)
        {
            var obj = ReadBaseProperties(root);
            obj.ElementSize = root.GetProperty("ElementSize").GetInt32();
            obj.Value = JsonSerializer.Deserialize<FObjectPtr>(root.GetProperty("Value").GetRawText(), options);
            return obj;
        }
        public void Write(Utf8JsonWriter writer, FStructProperty value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            WriteBaseProperties(writer, value);
            writer.WriteNumber("ElementSize", value.ElementSize);
            writer.WriteString("Value", value.Value.ToString());
            writer.WriteEndObject();
        }
    }
}
