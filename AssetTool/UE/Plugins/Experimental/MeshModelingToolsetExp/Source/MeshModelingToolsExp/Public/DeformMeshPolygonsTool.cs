namespace AssetTool
{
    [JsonAsset("DeformMeshPolygonsToolBuilder")]
    public class UDeformMeshPolygonsToolBuilder : UMeshSurfacePointMeshEditingToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DeformMeshPolygonsTransformProperties")]
    public class UDeformMeshPolygonsTransformProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DeformMeshPolygonsTool")]
    public class UDeformMeshPolygonsTool : UMeshSurfacePointTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}