namespace AssetTool.UE.Runtime.Engine.Public
{
    [TransferableStruct("PerPlatformInt")]
    public class FPerPlatformInt : ITransferable
    {
        public bool bCooked;
        public Int32 Default;
        public Dictionary<FName, TInt32> PerPlatform;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref bCooked);
            transfer.Move(ref Default);
            if (!bCooked)
            {
                transfer.Move(ref PerPlatform);
            }
            return this;
        }
    }

    [TransferableStruct("PerPlatformFrameRate")]
    public class FPerPlatformFrameRate : ITransferable
    {
        public FFrameRate Value;
        public FName Name;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Value);
            transfer.Move(ref Name);
            return this;
        }
    }
}
