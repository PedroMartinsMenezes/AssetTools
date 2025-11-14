namespace AssetTool
{
    [JsonAsset("LevelThumbnailRenderer")]
    public class ULevelThumbnailRenderer : UDefaultSizedThumbnailRenderer
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}