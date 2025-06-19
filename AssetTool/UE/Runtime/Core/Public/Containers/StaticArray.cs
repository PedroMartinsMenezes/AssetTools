namespace AssetTool
{
    public class TStaticArray<T> : ITransferible where T : ITransferible
    {
        public List<T> Values;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Values);
            return this;
        }
    }
}
