namespace AssetTool
{
    public class TSharedPtr<T> : ITransferable where T : ITransferable, new()
    {
        public ITransferable Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }
}
