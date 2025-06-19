namespace AssetTool
{
    public class TListOfList<T> : ITransferible where T : ITransferible, new()
    {
        public List<TList<T>> Items;

        public ITransferible Move2(Transfer transfer)
        {
            transfer.Move(ref Items);
            return this;
        }
    }
}
