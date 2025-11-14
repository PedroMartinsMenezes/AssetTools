namespace AssetTool
{
    public class TStaticArray<T> : ITransferable where T : ITransferable, new()
    {
        public List<T> Values;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Values);
            return this;
        }
    }
}
