namespace AssetTool
{
    [JsonAsset("PlatformMediaSource")]
    public class UPlatformMediaSource : UMediaSource
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}