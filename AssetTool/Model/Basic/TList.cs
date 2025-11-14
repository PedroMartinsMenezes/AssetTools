namespace AssetTool
{
    public class TList<T> : ITransferable where T : ITransferable, new()
    {
        public List<T> Items;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Items);
            return this;
        }
    }
}
