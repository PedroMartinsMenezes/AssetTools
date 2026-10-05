using System.Text.Json;

namespace AssetTool
{
    public class FSoftClassProperty : FSoftObjectProperty
    {
        public new const string TYPE_NAME = "SoftClassProperty";
        public override string TypeName => TYPE_NAME;

        public UInt32 MetaClass;

        [Location("void FSoftClassProperty::Serialize( FArchive& Ar )")]
        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref MetaClass);
            return this;
        }

        public override FProperty Read(JsonProperty elem, JsonSerializerOptions options)
        {
            string key = elem.Name;

            JsonElement value = elem.Value;

            var obj = ReadKeyValue<FSoftClassProperty>(key, value);

            obj.ElementSize = key.GetNonNull("ElementSize({0})", x => int.Parse(x), 0);

            obj.Value = key.GetNonNull("Value({0})", x => uint.Parse(x), (uint)0);
            obj.MetaClass = key.GetNonNull("MetaClass({0})", x => uint.Parse(x), (uint)0);

            return obj;
        }

        public override void Write(Utf8JsonWriter writer, JsonSerializerOptions options)
        {
            Dictionary<string, object> inlineFields = new()
            {
                ["ElementSize"] = this.ElementSize,
                ["Value"] = this.Value,
                ["MetaClass"] = this.MetaClass
            };
            WriteKeyValue(writer, options, this, "prop-softclass", inlineFields);
        }
    }
}
