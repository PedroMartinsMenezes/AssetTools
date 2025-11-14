namespace AssetTool
{
    [JsonAsset("MeshSelectionToolBuilder")]
    public class UMeshSelectionToolBuilder : UMeshSurfacePointMeshEditingToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeshSelectionToolActionPropertySet")]
    public class UMeshSelectionToolActionPropertySet : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeshSelectionEditActions")]
    public class UMeshSelectionEditActions : UMeshSelectionToolActionPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeshSelectionMeshEditActions")]
    public class UMeshSelectionMeshEditActions : UMeshSelectionToolActionPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeshSelectionToolProperties")]
    public class UMeshSelectionToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeshSelectionTool")]
    public class UMeshSelectionTool : UDynamicMeshBrushTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}