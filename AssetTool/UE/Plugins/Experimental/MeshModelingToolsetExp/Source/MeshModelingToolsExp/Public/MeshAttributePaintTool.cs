namespace AssetTool
{
    [JsonAsset("MeshAttributePaintToolBuilder")]
    public class UMeshAttributePaintToolBuilder : UMeshSurfacePointMeshEditingToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeshAttributePaintBrushOperationProperties")]
    public class UMeshAttributePaintBrushOperationProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeshAttributePaintToolProperties")]
    public class UMeshAttributePaintToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeshAttributePaintEditActions")]
    public class UMeshAttributePaintEditActions : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeshAttributePaintTool")]
    public class UMeshAttributePaintTool : UDynamicMeshBrushTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}