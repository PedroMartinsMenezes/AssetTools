namespace AssetTool
{
    [JsonAsset("MeshPaintingToolProperties")]
    public class UMeshPaintingToolProperties : UBrushBaseProperties
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}