namespace AssetTool
{
    [StructSerializable("PerPlatformFloat")]
    public class FPerPlatformFloat : ITransferible
    {
        public const string StructName = "PerPlatformFloat";

        public FBool bCooked;
        public float Value;
        public Dictionary<FName, TInt32> PerPlatform = [];

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref bCooked);
            transfer.Move(ref Value);
            if (!bCooked.Value)
            {
                PerPlatform.Move(transfer, (key) => transfer.Move(key), (value) => value.Move(transfer));
            }
            return this;
        }
    }
}
