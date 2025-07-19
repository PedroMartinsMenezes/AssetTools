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

            if (ElementSize < 0)
                throw new InvalidOperationException();

            transfer.Move(ref ElementCount);
            transfer.Move(ref Items, ElementCount);
            return this;
        }
    }
}
