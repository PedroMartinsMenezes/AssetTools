using System.Text.Json.Serialization;

namespace AssetTool
{
    [Location("void UScriptStruct::Serialize( FArchive& Ar )")]
    public class UScriptStruct : UStruct
    {
        [JsonPropertyOrder(-7)] public UInt32 StructFlags;

        public new UScriptStruct Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref StructFlags);
            return this;
        }
    }
}
