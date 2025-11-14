namespace AssetTool
{
    [JsonAsset("PlatformSettings")]
    public class UPlatformSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}