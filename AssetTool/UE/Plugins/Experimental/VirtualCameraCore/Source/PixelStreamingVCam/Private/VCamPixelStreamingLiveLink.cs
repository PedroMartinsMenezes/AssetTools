namespace AssetTool
{
    [JsonAsset("PixelStreamingLiveLinkSourceSettings")]
    public class UPixelStreamingLiveLinkSourceSettings : ULiveLinkSourceSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}