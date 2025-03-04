namespace AssetTool
{
    [JsonAsset("PixelStreamingLiveLinkSourceSettings")]
    public class UPixelStreamingLiveLinkSourceSettings : ULiveLinkSourceSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}