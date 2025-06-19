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
            //Items = Items.Resize(transfer, Size);
            //Items.ForEach(x => x.Move2(transfer));
            return this;
        }
    }
}
