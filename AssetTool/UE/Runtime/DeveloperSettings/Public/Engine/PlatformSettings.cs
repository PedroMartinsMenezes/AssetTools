namespace AssetTool
{
    [JsonAsset("PlatformSettings")]
    public class UPlatformSettings : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}