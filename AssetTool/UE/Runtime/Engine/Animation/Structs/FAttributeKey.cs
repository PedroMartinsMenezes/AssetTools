namespace AssetTool
{
    public class FAttributeKey : ITransferible
    {
        public float Time;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Time);
            return this;
        }
    }
}
