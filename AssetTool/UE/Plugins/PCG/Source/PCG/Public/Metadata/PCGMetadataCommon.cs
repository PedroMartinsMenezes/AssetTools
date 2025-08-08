using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("{Flag} {CustomFlag}")]
    public class FPCGMetadataDomainID : ITransferible
    {
        public EPCGMetadataDomainFlag Flag;
        public int32 CustomFlag;
        public bool IsDefault() => Flag == EPCGMetadataDomainFlag.Default;
        public bool IsValid() => Flag != EPCGMetadataDomainFlag.Invalid;

        [Location("friend FArchive& operator<<(FArchive& Ar, FPCGMetadataDomainID& Item)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.MoveEnum(ref Flag);
            transfer.Move(ref CustomFlag);
            return this;
        }
    }

    public enum EPCGMetadataDomainFlag : uint8
    {
        Default = 0,
        Data = 1,
        Elements = 2,
        Invalid = 254,
        Custom = 255
    }
}
