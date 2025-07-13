namespace AssetTool
{
    [JsonAsset("SVGThumbnailRenderer")]
    public class USVGThumbnailRenderer : UDefaultSizedThumbnailRenderer
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}