using System.Text.Json;

namespace AssetTool
{
    public class FLazyObjectProperty : FProperty
    {
        public new const string TYPE_NAME = "LazyObjectProperty";
        public override string TypeName => TYPE_NAME;

        public UInt32 Value;

        [Location("void FLazyObjectProperty::SerializeItem( FStructuredArchive::FSlot Slot, void* Value, void const* Defaults ) const")]
        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref Value);
            return this;
        }
    }

    public class FLazyObjectPropertySerializer : FPropertySerializerBase<FLazyObjectProperty>
    {
        public FLazyObjectProperty Read(JsonElement root, JsonSerializerOptions options)
        {
            string key = root.EnumerateObject().First().Name;

            JsonElement value = root.EnumerateObject().First().Value;

            var obj = ReadKeyValue(key, value);

            obj.ElementSize = key.GetNonNull("ElementSize({0})", x => int.Parse(x), 0);

            obj.Value = key.GetNonNull("Value({0})", x => uint.Parse(x), (uint)0);

            return obj;
        }

        public void Write(Utf8JsonWriter writer, FLazyObjectProperty value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            Dictionary<string, object> inlineFields = new()
            {
                ["ElementSize"] = value.ElementSize,
                ["Value"] = value.Value
            };

            WriteKeyValue(writer, options, value, "prop-lazyobject", inlineFields);

            writer.WriteEndObject();
        }
    }
}