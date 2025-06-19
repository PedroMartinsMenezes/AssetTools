namespace AssetTool
{
    [JsonAsset("FleshAssetThumbnailRenderer")]
    public class UFleshAssetThumbnailRenderer : UDefaultSizedThumbnailRenderer
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}