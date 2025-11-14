namespace AssetTool
{
    [TransferableStruct("PerPlatformFloat")]
    public class FPerPlatformFloat : ITransferable
    {
        public const string StructName = "PerPlatformFloat";

        public FBool bCooked;
        public float Value;
        public Dictionary<FName, TInt32> PerPlatform = [];

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref bCooked);
            transfer.Move(ref Value);
            if (!bCooked.Value)
            {
                transfer.Move(ref PerPlatform);
            }
            return this;
        }
    }
}
