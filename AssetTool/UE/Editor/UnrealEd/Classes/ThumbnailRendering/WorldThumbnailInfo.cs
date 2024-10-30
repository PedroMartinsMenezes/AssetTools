namespace AssetTool
{
    [JsonAsset("WorldThumbnailInfo")]
    public class UWorldThumbnailInfo : USceneThumbnailInfo
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}