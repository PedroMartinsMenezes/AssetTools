namespace AssetTool
{
    public class FCompressedChunkInfo : ITransferable
    {
        public uint64 CompressedSize;
        public uint64 UncompressedSize;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref CompressedSize);
            transfer.Move(ref UncompressedSize);
            return this;
        }
    }
}
