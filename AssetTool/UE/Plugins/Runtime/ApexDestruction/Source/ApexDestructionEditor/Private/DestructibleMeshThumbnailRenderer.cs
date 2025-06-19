namespace AssetTool
{
    [JsonAsset("DestructibleMeshThumbnailRenderer")]
    public class UDestructibleMeshThumbnailRenderer : UDefaultSizedThumbnailRenderer
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}