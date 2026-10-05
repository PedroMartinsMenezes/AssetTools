using System.Text.Json;

namespace AssetTool
{
    public class FDelegateProperty : FProperty
    {
        public new const string TYPE_NAME = "DelegateProperty";
        public override string TypeName => TYPE_NAME;

        public UInt32 SignatureFunction;
        public UInt64 Ptr;

        [Location("void FDelegateProperty::Serialize( FArchive& Ar )")]
        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref SignatureFunction);
            return this;
        }

        public FDelegateProperty MoveValue(Transfer transfer)
        {
            transfer.Move(ref SignatureFunction);
            transfer.Move(ref Ptr);
            return this;
        }

        public override FProperty Read(JsonProperty elem, JsonSerializerOptions options)
        {
            string key = elem.Name;

            JsonElement value = elem.Value;

            var obj = ReadKeyValue<FDelegateProperty>(key, value);

            obj.ElementSize = key.GetNonNull("ElementSize({0})", x => int.Parse(x), 0);
            obj.SignatureFunction = key.GetNonNull("SignatureFunction({0})", x => uint.Parse(x), (uint)0);
            obj.Ptr = key.GetNonNull("Ptr({0})", x => ulong.Parse(x), (ulong)0);

            return obj;
        }

        public override void Write(Utf8JsonWriter writer, JsonSerializerOptions options)
        {
            Dictionary<string, object> inlineFields = new()
            {
                ["ElementSize"] = this.ElementSize,
                ["SignatureFunction"] = this.SignatureFunction,
                ["Ptr"] = this.Ptr
            };

            WriteKeyValue(writer, options, this, "prop-delegate", inlineFields);
        }
    }
}
