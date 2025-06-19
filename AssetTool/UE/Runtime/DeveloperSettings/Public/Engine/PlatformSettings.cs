namespace AssetTool
{
    [JsonAsset("PlatformSettings")]
    public class UPlatformSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}