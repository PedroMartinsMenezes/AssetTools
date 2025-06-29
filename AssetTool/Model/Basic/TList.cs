namespace AssetTool
{
    public class TList<T> : ITransferible where T : ITransferible, new()
    {
        public List<T> Items;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Items);
            return this;
        }
    }
}
