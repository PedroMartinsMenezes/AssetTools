namespace AssetTool
{
    [JsonAsset("WorldThumbnailRenderer")]
    public class UWorldThumbnailRenderer : UDefaultSizedThumbnailRenderer
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}