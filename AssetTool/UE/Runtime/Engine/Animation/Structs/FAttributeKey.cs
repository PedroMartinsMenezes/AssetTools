namespace AssetTool
{
    public class FAttributeKey
    {
        public float Time;

        public FAttributeKey Move(Transfer transfer)
        {
            transfer.Move(ref Time);
            return this;
        }
    }
}
