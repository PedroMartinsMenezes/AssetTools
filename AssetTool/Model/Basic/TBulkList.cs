namespace AssetTool
{
    public class TBulkList<T> : ITransferible where T : ITransferible, new()
    {
        public int ElementSize;
        public int ElementCount;
        public T[] Items;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref ElementSize);
            transfer.Move(ref ElementCount);
            transfer.Move(ref Items, ElementCount);
            return this;
        }
    }
}
