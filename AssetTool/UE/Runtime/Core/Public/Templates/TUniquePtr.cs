namespace AssetTool
{
    public class TUniquePtr<T> : ITransferable where T : ITransferable, new()
    {
        public ITransferable Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }
}
