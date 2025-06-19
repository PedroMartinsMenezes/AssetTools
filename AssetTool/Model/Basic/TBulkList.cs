namespace AssetTool
{
    public class TBulkList<T> : ITransferible where T : ITransferible
    {
        public int ElementSize;
        public int ElementCount;
        public T[] Items;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref ElementSize);
            transfer.Move(ref ElementCount);
            transfer.Move(ref Items, ElementCount);
            //Items = Items.Resize(transfer, ElementCount);
            //Items.ForEach(x => x.Move2(transfer));
            return this;
        }
    }
}
