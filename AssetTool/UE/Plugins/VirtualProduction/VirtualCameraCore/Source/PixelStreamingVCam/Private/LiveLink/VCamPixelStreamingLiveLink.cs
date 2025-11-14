namespace AssetTool
{
    [JsonAsset("PixelStreamingLiveLinkSourceSettings")]
    public class UPixelStreamingLiveLinkSourceSettings : ULiveLinkSourceSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}