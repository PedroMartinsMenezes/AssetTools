namespace AssetTool
{
    [JsonAsset("EnhancedInputPlatformData")]
    public class UEnhancedInputPlatformData : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EnhancedInputPlatformSettings")]
    public class UEnhancedInputPlatformSettings : UPlatformSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}