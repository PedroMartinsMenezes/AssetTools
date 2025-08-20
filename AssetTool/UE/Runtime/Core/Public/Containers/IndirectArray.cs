namespace AssetTool
{
    public class TIndirectArray<T> : ITransferible where T : ITransferible, new()
    {
        public List<T> Values;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Values);
            return this;
        }
    }
}
