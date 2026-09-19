using System.Text.Json;

namespace AssetTool
{
    public class FWeakObjectProperty : FProperty
    {
        public new const string TYPE_NAME = "WeakObjectProperty";
        public override string TypeName => TYPE_NAME;

        public UInt32 Value;

        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref Value);
            return this;
        }
    }

    public class FWeakObjectPropertySerializer : FPropertySerializerBase<FWeakObjectProperty>
    {
        public FWeakObjectProperty Read(JsonElement root, JsonSerializerOptions options)
        {
            string key = root.EnumerateObject().First().Name;
            JsonElement value = root.EnumerateObject().First().Value;
            var obj = ReadKeyValue(key, value);
            obj.ElementSize = key.GetNonNull("ElementSize({0})", x => int.Parse(x), 0);
            obj.Value = key.GetNonNull("Value({0})", x => uint.Parse(x), (uint)0);
            return obj;
        }

        public void Write(Utf8JsonWriter writer, FWeakObjectProperty value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            Dictionary<string, object> inlineFields = new()
            {
                ["ElementSize"] = value.ElementSize,
                ["Value"] = value.Value
            };
            WriteKeyValue(writer, options, value, "prop-weakobject", inlineFields);
            writer.WriteEndObject();
        }
    }
}
