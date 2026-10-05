namespace AssetTool
{
    public class FRigVMObjectArchive : ITransferable
    {
        public uint8[] Buffer;
        public int32 UncompressedSize;
        public int32 CompressedSize;
        public bool bIsCompressed;

        [Location("FArchive& operator<<(FArchive& Ar, FRigVMObjectArchive& Data)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Buffer);
            transfer.Move(ref UncompressedSize);
            transfer.Move(ref CompressedSize);
            transfer.Move(ref bIsCompressed);
            return this;
        }
    }
}
