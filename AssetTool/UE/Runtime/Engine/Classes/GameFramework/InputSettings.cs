namespace AssetTool
{
    [JsonAsset("InputSettings")]
    public class UInputSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InputPlatformSettings")]
    public class UInputPlatformSettings : UPlatformSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}