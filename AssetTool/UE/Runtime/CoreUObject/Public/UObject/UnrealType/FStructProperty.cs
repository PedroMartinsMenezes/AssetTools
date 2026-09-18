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
            string key = root.EnumerateObject().First().Name;

            JsonElement value = root.EnumerateObject().First().Value;

            var obj = ReadKeyValue(key, value);

            obj.ElementSize = key.GetNonNull("ElementSize({0})", x => int.Parse(x), 0);
            obj.Value = key.GetNonNull("Value({0})", x => FObjectPtr.FromString(x), new FObjectPtr { Index = new FPackageIndex() });

            return obj;
        }
        public void Write(Utf8JsonWriter writer, FStructProperty value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            Dictionary<string, object> inlineFields = new()
            {
                ["ElementSize"] = value.ElementSize,
                ["Value"] = value.Value
            };

            WriteKeyValue(writer, options, value, "prop-struct", inlineFields);

            writer.WriteEndObject();
        }
    }
}
