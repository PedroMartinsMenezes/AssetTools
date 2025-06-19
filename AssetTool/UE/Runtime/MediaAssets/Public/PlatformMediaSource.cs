namespace AssetTool
{
    [JsonAsset("PlatformMediaSource")]
    public class UPlatformMediaSource : UMediaSource
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}