namespace AssetTool
{
    public class TIndirectArray<T> : ITransferable where T : ITransferable, new()
    {
        public List<T> Values;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Values);
            return this;
        }
    }
}
