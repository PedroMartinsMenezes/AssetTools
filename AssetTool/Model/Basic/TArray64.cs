namespace AssetTool
{
    public class TArray64<T> : ITransferible where T : ITransferible, new()
    {
        public long Size;
        public T[] Items;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Size);
            transfer.Move(ref Items, (int)Size);
            return this;
        }
    }

    public class TArray64Byte : ITransferible
    {
        public long Size;
        public byte[] Items;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Size);
            transfer.Move(ref Items, (int)Size);
            return this;
        }
    }
}
