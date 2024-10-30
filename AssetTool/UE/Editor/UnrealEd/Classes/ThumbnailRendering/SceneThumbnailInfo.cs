namespace AssetTool
{
    [JsonAsset("SceneThumbnailInfo")]
    public class USceneThumbnailInfo : UThumbnailInfo
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}