namespace AssetTool
{
    [JsonAsset("GroomAssetThumbnailRenderer")]
    public class UGroomAssetThumbnailRenderer : UDefaultSizedThumbnailRenderer
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}