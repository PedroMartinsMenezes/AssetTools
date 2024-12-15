namespace AssetTool
{
    public class TBulkList<T> : ITransferible where T : ITransferible, new()
    {
        public int ElementSize;
        public int ElementCount;
        public List<T> Items;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref ElementSize);
            transfer.Move(ref ElementCount);
            Items = Items.Resize(transfer, ElementCount);
            Items.ForEach(x => x.Move(transfer));
            return this;
        }
    }
}
