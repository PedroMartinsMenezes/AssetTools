namespace AssetTool
{
    public class TArray64<T> : ITransferable where T : ITransferable, new()
    {
        public long Size;
        public T[] Items;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Size);
            transfer.Move(ref Items, (int)Size);
            return this;
        }
    }

    public class TArray64Byte : ITransferable
    {
        public long Size;
        public byte[] Items;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Size);
            transfer.Move(ref Items, (int)Size);
            return this;
        }
    }
}
