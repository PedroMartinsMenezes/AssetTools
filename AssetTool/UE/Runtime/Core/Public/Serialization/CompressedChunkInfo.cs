namespace AssetTool
{
    public class FCompressedChunkInfo : ITransferible
    {
        public uint64 CompressedSize;
        public uint64 UncompressedSize;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref CompressedSize);
            transfer.Move(ref UncompressedSize);
            return this;
        }
    }
}
