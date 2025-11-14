namespace AssetTool
{
    [JsonAsset("AvaShapeIrregularPolygonDynamicMesh")]
    public class UAvaShapeIrregularPolygonDynamicMesh : UAvaShape2DDynMeshBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}