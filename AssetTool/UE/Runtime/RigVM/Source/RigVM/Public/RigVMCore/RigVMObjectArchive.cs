namespace AssetTool
{
    public class FRigVMObjectArchive : ITransferible
    {
        public uint8[] Buffer;
        public int32 UncompressedSize;
        public int32 CompressedSize;
        public FBool bIsCompressed;

        [Location("FArchive& operator<<(FArchive& Ar, FRigVMObjectArchive& Data)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Buffer);
            transfer.Move(ref UncompressedSize);
            transfer.Move(ref CompressedSize);
            transfer.Move(ref bIsCompressed);
            return this;
        }
    }
}
