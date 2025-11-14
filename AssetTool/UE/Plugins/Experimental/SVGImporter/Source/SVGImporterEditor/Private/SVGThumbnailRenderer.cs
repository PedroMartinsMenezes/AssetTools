namespace AssetTool
{
    [JsonAsset("SVGThumbnailRenderer")]
    public class USVGThumbnailRenderer : UDefaultSizedThumbnailRenderer
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}