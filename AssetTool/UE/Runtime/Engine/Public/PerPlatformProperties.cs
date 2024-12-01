namespace AssetTool.UE.Runtime.Engine.Public
{
    [TransferibleStruct("PerPlatformInt")]
    public class FPerPlatformInt : ITransferible
    {
        public FBool bCooked;
        public Int32 Default;
        public Dictionary<FName, TInt32> PerPlatform;

        public ITransferible Move(Transfer transfer)
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
}
