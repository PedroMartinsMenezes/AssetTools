namespace AssetTool
{
    [JsonAsset("SceneThumbnailInfoWithPrimitive")]
    public class USceneThumbnailInfoWithPrimitive : USceneThumbnailInfo
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}