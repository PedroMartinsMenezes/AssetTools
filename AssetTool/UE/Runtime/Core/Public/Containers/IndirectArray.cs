namespace AssetTool
{
    public class TIndirectArray<T> : ITransferible
    {
        public List<T> Values;

        public ITransferible Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }
}
