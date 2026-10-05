namespace AssetTool
{
    public class TOptional<T> : ITransferable where T : ITransferable, new()
    {
        public bool bOptionalWasSaved;
        public T Value;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref bOptionalWasSaved);
            if (bOptionalWasSaved)
            {
                transfer.Move(ref Value);
            }
            return this;
        }
    }
}
