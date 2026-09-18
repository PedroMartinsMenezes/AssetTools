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
    }

    public class FSoftClassPropertySerializer : FPropertySerializerBase<FSoftClassProperty>
    {
        public FSoftClassProperty Read(JsonElement root, JsonSerializerOptions options)
        {
            string key = root.EnumerateObject().First().Name;

            JsonElement value = root.EnumerateObject().First().Value;

            var obj = ReadKeyValue(key, value);

            obj.ElementSize = key.GetNonNull("ElementSize({0})", x => int.Parse(x), 0);

            obj.Value = key.GetNonNull("Value({0})", x => uint.Parse(x), (uint)0);
            obj.MetaClass = key.GetNonNull("MetaClass({0})", x => uint.Parse(x), (uint)0);

            return obj;
        }

        public void Write(Utf8JsonWriter writer, FSoftClassProperty value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            Dictionary<string, object> inlineFields = new()
            {
                ["ElementSize"] = value.ElementSize,
                ["Value"] = value.Value,
                ["MetaClass"] = value.MetaClass
            };

            WriteKeyValue(writer, options, value, "prop-softclass", inlineFields);

            writer.WriteEndObject();
        }
    }
}
