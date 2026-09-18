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
    }

    public class FMulticastInlineDelegatePropertySerializer : FPropertySerializerBase<FMulticastInlineDelegateProperty>
    {
        public FMulticastInlineDelegateProperty Read(JsonElement root, JsonSerializerOptions options)
        {
            string key = root.EnumerateObject().First().Name;

            JsonElement value = root.EnumerateObject().First().Value;

            var obj = ReadKeyValue(key, value);

            obj.ElementSize = key.GetNonNull("ElementSize({0})", x => int.Parse(x), 0);

            obj.PropertyValuePtr = key.GetNonNull("PropertyValuePtr({0})", x => uint.Parse(x), (uint)0);

            if (root.TryGetProperty("InvocationList", out var invocationList) && invocationList.ValueKind == JsonValueKind.Array)
            {
                obj.InvocationList = JsonSerializer.Deserialize<List<TScriptDelegate>>(invocationList.GetRawText(), options);
            }

            return obj;
        }

        public void Write(Utf8JsonWriter writer, FMulticastInlineDelegateProperty value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            Dictionary<string, object> inlineFields = new()
            {
                ["ElementSize"] = value.ElementSize,
                ["PropertyValuePtr"] = value.PropertyValuePtr,
            };

            Dictionary<string, object> fields = null;
            if (value.InvocationList is { })
            {
                fields = new()
                {
                    ["InvocationList"] = value.InvocationList,
                };
            }

            WriteKeyValue(writer, options, value, "prop-multicast-inline-delegate", inlineFields, fields);

            writer.WriteEndObject();
        }
    }
}