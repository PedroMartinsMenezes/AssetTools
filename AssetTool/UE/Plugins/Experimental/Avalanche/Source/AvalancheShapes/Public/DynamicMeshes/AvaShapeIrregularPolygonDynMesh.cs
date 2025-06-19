namespace AssetTool
{
    [JsonAsset("AvaShapeIrregularPolygonDynamicMesh")]
    public class UAvaShapeIrregularPolygonDynamicMesh : UAvaShape2DDynMeshBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}