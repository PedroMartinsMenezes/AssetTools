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

        public override FProperty Read(JsonProperty elem, JsonSerializerOptions options)
        {
            string key = elem.Name;

            JsonElement value = elem.Value;

            var obj = ReadKeyValue<FStructProperty>(key, value);

            obj.ElementSize = key.GetNonNull("ElementSize({0})", x => int.Parse(x), 0);
            obj.Value = key.GetNonNull("Value({0})", x => FObjectPtr.FromString(x), new FObjectPtr { Index = new FPackageIndex() });

            return obj;
        }

        public override void Write(Utf8JsonWriter writer, JsonSerializerOptions options)
        {
            Dictionary<string, object> inlineFields = new()
            {
                ["ElementSize"] = this.ElementSize,
                ["Value"] = this.Value
            };
            WriteKeyValue(writer, options, this, "prop-struct", inlineFields);
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
}
