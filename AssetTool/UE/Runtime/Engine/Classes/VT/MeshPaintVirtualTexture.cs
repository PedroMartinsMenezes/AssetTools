namespace AssetTool
{
    [JsonAsset("MeshPaintVirtualTexture")]
    public class UMeshPaintVirtualTexture : UTexture2D
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}