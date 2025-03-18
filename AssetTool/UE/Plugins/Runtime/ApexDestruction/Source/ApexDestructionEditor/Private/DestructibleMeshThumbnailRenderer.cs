namespace AssetTool
{
    [JsonAsset("DestructibleMeshThumbnailRenderer")]
    public class UDestructibleMeshThumbnailRenderer : UDefaultSizedThumbnailRenderer
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}