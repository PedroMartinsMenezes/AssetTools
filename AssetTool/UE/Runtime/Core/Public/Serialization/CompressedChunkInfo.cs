namespace AssetTool
{
    public class FCompressedChunkInfo : ITransferible
    {
        public int64 CompressedSize;
        public int64 UncompressedSize;

        public ITransferible Move2(Transfer transfer)
        {
            transfer.Move(ref CompressedSize);
            transfer.Move(ref UncompressedSize);
            return this;
        }
    }
}
