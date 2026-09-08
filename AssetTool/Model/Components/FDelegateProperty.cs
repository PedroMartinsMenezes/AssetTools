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
    }

    public class FDelegatePropertySerializer : FPropertySerializerBase<FDelegateProperty>
    {
        public FDelegateProperty Read(JsonElement root, JsonSerializerOptions options)
        {
            var obj = ReadBaseProperties(root);
            obj.ElementSize = root.GetProperty("ElementSize").GetInt32();
            obj.SignatureFunction = root.GetProperty("SignatureFunction").GetUInt32();
            obj.Ptr = root.GetProperty("Ptr").GetUInt64();
            return obj;
        }

        public void Write(Utf8JsonWriter writer, FDelegateProperty value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            WriteBaseProperties(writer, value);
            writer.WriteNumber("ElementSize", value.ElementSize);
            writer.WriteNumber("SignatureFunction", value.SignatureFunction);
            writer.WriteNumber("Ptr", value.Ptr);
            writer.WriteEndObject();
        }
    }
}
