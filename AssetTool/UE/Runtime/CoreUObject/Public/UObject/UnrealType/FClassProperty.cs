using System.Text.Json;

namespace AssetTool
{
    public class FClassProperty : FObjectProperty
    {
        public new const string TYPE_NAME = "ClassProperty";
        public override string TypeName => TYPE_NAME;

        public UInt32 MetaClass;

        [Location("void FClassProperty::Serialize( FArchive& Ar )")]
        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref MetaClass);
            return this;
        }
    }

    public class FClassPropertySerializer : FPropertySerializerBase<FClassProperty>
    {
        public FClassProperty Read(JsonElement root, JsonSerializerOptions options)
        {
            string key = root.EnumerateObject().First().Name;

            JsonElement value = root.EnumerateObject().First().Value;

            var obj = ReadKeyValue(key, value);

            obj.ElementSize = 8;

            obj.Value = key.GetNonNull("Value({0})", x => FObjectPtr.FromString(x), new FObjectPtr { Index = new FPackageIndex() });
            obj.MetaClass = key.GetNonNull("MetaClass({0})", x => uint.Parse(x), (uint)0);

            return obj;
        }

        public void Write(Utf8JsonWriter writer, FClassProperty value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            Dictionary<string, object> inlineFields = new()
            {
                ["Value"] = value.Value,
                ["MetaClass"] = value.MetaClass
            };

            WriteKeyValue(writer, options, value, "prop-class", inlineFields);

            writer.WriteEndObject();
        }
    }
}
