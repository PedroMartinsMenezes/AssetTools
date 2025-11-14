namespace AssetTool
{
    public class FAttributeKey : ITransferable
    {
        public float Time;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Time);
            return this;
        }
    }
}
