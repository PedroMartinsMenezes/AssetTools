namespace AssetTool
{
    public class TOptional<T> : ITransferible where T : ITransferible, new()
    {
        public FBool bOptionalWasSaved;
        public T Value;

        public ITransferible Move(Transfer transfer)
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
