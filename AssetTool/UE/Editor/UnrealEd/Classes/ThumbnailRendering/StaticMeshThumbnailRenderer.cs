namespace AssetTool
{
    [JsonAsset("StaticMeshThumbnailRenderer")]
    public class UStaticMeshThumbnailRenderer : UDefaultSizedThumbnailRenderer
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}