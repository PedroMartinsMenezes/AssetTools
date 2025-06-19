namespace AssetTool.UE.Runtime.Engine.Public
{
    [TransferibleStruct("PerPlatformInt")]
    public class FPerPlatformInt : ITransferible
    {
        public FBool bCooked;
        public Int32 Default;
        public Dictionary<FName, TInt32> PerPlatform;

        public ITransferible Move2(Transfer transfer)
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

    [TransferibleStruct("PerPlatformFrameRate")]
    public class FPerPlatformFrameRate : ITransferible
    {
        public FFrameRate Value;
        public FName Name;

        public ITransferible Move2(Transfer transfer)
        {
            transfer.Move(ref Value);
            transfer.Move(ref Name);
            return this;
        }
    }
}
