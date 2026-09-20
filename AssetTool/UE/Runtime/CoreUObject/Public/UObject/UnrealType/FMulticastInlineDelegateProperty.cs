using System.Text.Json;

namespace AssetTool
{
    public class FMulticastInlineDelegateProperty : FProperty
    {
        public new const string TYPE_NAME = "MulticastInlineDelegateProperty";
        public override string TypeName => TYPE_NAME;

        public UInt32 PropertyValuePtr;
        public List<TScriptDelegate> InvocationList;

        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref PropertyValuePtr);
            return this;
        }

        [Location("void FMulticastInlineDelegateProperty::SerializeItem(FStructuredArchive::FSlot Slot, void* Value, void const* Defaults) const")]
        public FField SerializeItem(Transfer transfer)
        {
            transfer.Move(ref InvocationList);
            return this;
        }

        public override FProperty Read(JsonProperty elem, JsonSerializerOptions options)
        {
            string key = elem.Name;

            JsonElement value = elem.Value;

            var obj = ReadKeyValue<FMulticastInlineDelegateProperty>(key, value);

            obj.ElementSize = key.GetNonNull("ElementSize({0})", x => int.Parse(x), 0);

            obj.PropertyValuePtr = key.GetNonNull("PropertyValuePtr({0})", x => uint.Parse(x), (uint)0);

            if (value.ValueKind == JsonValueKind.Object && value.TryGetProperty("InvocationList", out var invocationList) && invocationList.ValueKind == JsonValueKind.Array)
            {
                obj.InvocationList = JsonSerializer.Deserialize<List<TScriptDelegate>>(invocationList.GetRawText(), options);
            }

            return obj;
        }

        public override void Write(Utf8JsonWriter writer, JsonSerializerOptions options)
        {
            Dictionary<string, object> inlineFields = new()
            {
                ["ElementSize"] = this.ElementSize,
                ["PropertyValuePtr"] = this.PropertyValuePtr,
            };

            Dictionary<string, object> fields = null;
            if (this.InvocationList is { })
            {
                fields = new()
                {
                    ["InvocationList"] = this.InvocationList,
                };
            }

            WriteKeyValue(writer, options, this, "prop-multicast-inline-delegate", inlineFields, fields);
        }
    }
}
