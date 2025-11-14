namespace AssetTool
{
    [JsonAsset("FleshAssetThumbnailRenderer")]
    public class UFleshAssetThumbnailRenderer : UDefaultSizedThumbnailRenderer
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}