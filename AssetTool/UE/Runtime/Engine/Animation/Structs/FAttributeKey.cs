namespace AssetTool
{
    public class FAttributeKey : ITransferible
    {
        public float Time;

        public ITransferible Move2(Transfer transfer)
        {
            transfer.Move(ref Time);
            return this;
        }
    }
}
