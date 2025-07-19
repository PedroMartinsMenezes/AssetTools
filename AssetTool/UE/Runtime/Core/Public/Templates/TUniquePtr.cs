namespace AssetTool
{
    public class TUniquePtr<T> : ITransferible where T : ITransferible, new()
    {
        public ITransferible Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }
}
