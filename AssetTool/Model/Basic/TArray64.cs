namespace AssetTool
{
    public class TArray64<T> : ITransferible where T : ITransferible, new()
    {
        public long Size;
        public List<T> Items;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Size);
            Items = Items.Resize(transfer, Size);
            Items.ForEach(x => x.Move(transfer));
            return this;
        }
    }
}
