namespace AssetTool
{
    [JsonAsset("DeformMeshPolygonsToolBuilder")]
    public class UDeformMeshPolygonsToolBuilder : UMeshSurfacePointMeshEditingToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DeformMeshPolygonsTransformProperties")]
    public class UDeformMeshPolygonsTransformProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DeformMeshPolygonsTool")]
    public class UDeformMeshPolygonsTool : UMeshSurfacePointTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}