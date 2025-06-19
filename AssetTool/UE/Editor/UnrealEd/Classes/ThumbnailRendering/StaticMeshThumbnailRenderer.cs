namespace AssetTool
{
    [JsonAsset("StaticMeshThumbnailRenderer")]
    public class UStaticMeshThumbnailRenderer : UDefaultSizedThumbnailRenderer
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}