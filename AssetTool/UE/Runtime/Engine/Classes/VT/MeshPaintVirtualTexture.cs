namespace AssetTool
{
    [JsonAsset("MeshPaintVirtualTexture")]
    public class UMeshPaintVirtualTexture : UTexture2D
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}