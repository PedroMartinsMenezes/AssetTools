namespace AssetTool
{
    [JsonAsset("WorldThumbnailInfo")]
    public class UWorldThumbnailInfo : USceneThumbnailInfo
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}