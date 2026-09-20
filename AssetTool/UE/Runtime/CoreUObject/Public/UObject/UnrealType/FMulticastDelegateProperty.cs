using System.Text.Json;

namespace AssetTool
{
    public class FMulticastDelegateProperty : FProperty
    {
        public new const string TYPE_NAME = "MulticastDelegateProperty";
        public override string TypeName => TYPE_NAME;

        public UInt32 SignatureFunction;
        public Dictionary<FObjectPtr, FName> Delegates;

        [Location("void FMulticastDelegateProperty::Serialize( FArchive& Ar )")]
        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref SignatureFunction);
            return this;
        }

        public FMulticastDelegateProperty MoveValue(Transfer transfer)
        {
            transfer.Move(ref Delegates);
            return this;
        }

        public override FProperty Read(JsonElement root, JsonSerializerOptions options)
        {
            string key = root.EnumerateObject().First().Name;

            JsonElement value = root.EnumerateObject().First().Value;

            var obj = ReadKeyValue<FMulticastDelegateProperty>(key, value);

            obj.ElementSize = key.GetNonNull("ElementSize({0})", x => int.Parse(x), 0);

            obj.SignatureFunction = key.GetNonNull("SignatureFunction({0})", x => uint.Parse(x), (uint)0);

            if (root.TryGetProperty("Delegates", out var delegates) && delegates.ValueKind == JsonValueKind.Object)
            {
                obj.Delegates = JsonSerializer.Deserialize<Dictionary<FObjectPtr, FName>>(delegates.GetRawText(), options);
            }

            return obj;
        }

        public override void Write(Utf8JsonWriter writer, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            Dictionary<string, object> inlineFields = new()
            {
                ["ElementSize"] = this.ElementSize,
                ["SignatureFunction"] = this.SignatureFunction,
            };

            Dictionary<string, object> fields = null;
            if (this.Delegates is { })
            {
                fields = new()
                {
                    ["Delegates"] = this.Delegates,
                };
            }

            WriteKeyValue(writer, options, this, "prop-multicast-delegate", inlineFields, fields);

            writer.WriteEndObject();
        }
    }
}
