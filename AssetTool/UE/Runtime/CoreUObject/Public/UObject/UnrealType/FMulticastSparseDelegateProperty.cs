using System.Text.Json;

namespace AssetTool
{
    using FMulticastScriptDelegate = TMulticastScriptDelegate;

    public class FMulticastSparseDelegateProperty : FProperty
    {
        public new const string TYPE_NAME = "MulticastSparseDelegateProperty";
        public override string TypeName => TYPE_NAME;

        public FMulticastScriptDelegate Delegate;

        [Location("void FMulticastSparseDelegateProperty::SerializeItem(FStructuredArchive::FSlot Slot, void* Value, void const* Defaults) const")]
        public FMulticastSparseDelegateProperty SerializeItem(Transfer transfer)
        {
            transfer.Move(ref Delegate);
            return this;
        }

        public override FProperty Read(JsonProperty elem, JsonSerializerOptions options)
        {
            string key = elem.Name;

            JsonElement value = elem.Value;

            var obj = ReadKeyValue<FMulticastSparseDelegateProperty>(key, value);

            obj.ElementSize = key.GetNonNull("ElementSize({0})", x => int.Parse(x), 0);

            if (value.TryGetProperty("Delegate", out var del))
            {
                obj.Delegate = JsonSerializer.Deserialize<FMulticastScriptDelegate>(del.GetRawText(), options);
            }

            return obj;
        }

        public override void Write(Utf8JsonWriter writer, JsonSerializerOptions options)
        {
            Dictionary<string, object> inlineFields = new()
            {
                ["ElementSize"] = this.ElementSize
            };

            Dictionary<string, object> fields = null;
            if (this.Delegate is { })
            {
                fields = new()
                {
                    ["Delegate"] = this.Delegate
                };
            }

            WriteKeyValue(writer, options, this, "prop-multicast-sparse-delegate", inlineFields, fields);
        }
    }
}
