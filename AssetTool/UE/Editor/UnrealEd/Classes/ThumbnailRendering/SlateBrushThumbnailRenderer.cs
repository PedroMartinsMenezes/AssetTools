namespace AssetTool
{
    [JsonAsset("SlateBrushThumbnailRenderer")]
    public class USlateBrushThumbnailRenderer : UDefaultSizedThumbnailRenderer
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}