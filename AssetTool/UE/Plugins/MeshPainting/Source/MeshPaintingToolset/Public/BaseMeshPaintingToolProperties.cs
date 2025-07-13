namespace AssetTool
{
    [JsonAsset("MeshPaintingToolProperties")]
    public class UMeshPaintingToolProperties : UBrushBaseProperties
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}