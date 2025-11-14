namespace AssetTool
{
    [JsonAsset("GameInputPlatformSettings")]
    public class UGameInputPlatformSettings : UPlatformSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GameInputDeveloperSettings")]
    public class UGameInputDeveloperSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}