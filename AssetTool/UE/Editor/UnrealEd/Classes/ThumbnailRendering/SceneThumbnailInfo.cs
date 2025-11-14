namespace AssetTool
{
    [JsonAsset("SceneThumbnailInfo")]
    public class USceneThumbnailInfo : UThumbnailInfo
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}