namespace AssetTool
{
    [JsonAsset("StaticMeshThumbnailRenderer")]
    public class UStaticMeshThumbnailRenderer : UDefaultSizedThumbnailRenderer
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}