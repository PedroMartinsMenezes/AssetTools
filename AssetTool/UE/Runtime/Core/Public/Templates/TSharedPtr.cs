namespace AssetTool
{
    public class TSharedPtr<T> : ITransferible where T : ITransferible, new()
    {
        public ITransferible Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }
}
