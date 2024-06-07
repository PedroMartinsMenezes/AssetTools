namespace AssetTool
{
    public class FPerPlatformFloat
    {
        public const string StructName = "PerPlatformFloat";

        public FBool bCooked;
        public float Value;
        public Dictionary<FName, TInt32> PerPlatform = [];

        public FPerPlatformFloat Move(Transfer transfer)
        {
            transfer.Move(ref bCooked);
            transfer.Move(ref Value);
            if (!bCooked.Value)
            {
                PerPlatform.Resize(transfer);
                foreach (var pair in PerPlatform)
                {
                    transfer.Move(pair.Key);
                    pair.Value.Move(transfer);
                }
            }
            return this;
        }
    }
}
