namespace AssetTool
{
    [JsonAsset("LevelThumbnailRenderer")]
    public class ULevelThumbnailRenderer : UDefaultSizedThumbnailRenderer
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}