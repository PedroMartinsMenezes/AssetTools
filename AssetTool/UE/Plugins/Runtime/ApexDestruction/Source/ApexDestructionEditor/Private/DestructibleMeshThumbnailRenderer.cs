namespace AssetTool
{
    [JsonAsset("DestructibleMeshThumbnailRenderer")]
    public class UDestructibleMeshThumbnailRenderer : UDefaultSizedThumbnailRenderer
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}