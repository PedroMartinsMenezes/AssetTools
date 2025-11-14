namespace AssetTool
{
    [JsonAsset("ShapeSprayToolBuilder")]
    public class UShapeSprayToolBuilder : UMeshSurfacePointMeshEditingToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ShapeSprayToolProperties")]
    public class UShapeSprayToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ShapeSprayTool")]
    public class UShapeSprayTool : UDynamicMeshBrushTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}