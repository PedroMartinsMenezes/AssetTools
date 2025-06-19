namespace AssetTool
{
    [JsonAsset("WorldThumbnailInfo")]
    public class UWorldThumbnailInfo : USceneThumbnailInfo
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}