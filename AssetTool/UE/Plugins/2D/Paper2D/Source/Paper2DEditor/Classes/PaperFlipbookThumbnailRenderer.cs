namespace AssetTool
{
    [JsonAsset("PaperFlipbookThumbnailRenderer")]
    public class UPaperFlipbookThumbnailRenderer : UPaperSpriteThumbnailRenderer
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}