namespace AssetTool
{
    public class TListOfList<T> : ITransferable where T : ITransferable, new()
    {
        public List<TList<T>> Items;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Items);
            return this;
        }
    }
}
