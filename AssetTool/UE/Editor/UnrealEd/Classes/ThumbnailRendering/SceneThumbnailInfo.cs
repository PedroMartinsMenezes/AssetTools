namespace AssetTool
{
    [JsonAsset("SceneThumbnailInfo")]
    public class USceneThumbnailInfo : UThumbnailInfo
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}