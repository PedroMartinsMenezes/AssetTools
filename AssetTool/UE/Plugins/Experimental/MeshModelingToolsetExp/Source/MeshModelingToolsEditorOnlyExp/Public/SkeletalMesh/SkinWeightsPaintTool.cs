namespace AssetTool
{
    [JsonAsset("SkinWeightsPaintToolBuilder")]
    public class USkinWeightsPaintToolBuilder : UMeshSurfacePointMeshEditingToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SkinWeightsPaintToolProperties")]
    public class USkinWeightsPaintToolProperties : UBrushBaseProperties
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WeightToolMeshSelector")]
    public class UWeightToolMeshSelector : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WeightToolTransferManager")]
    public class UWeightToolTransferManager : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WeightToolSelectionIsolator")]
    public class UWeightToolSelectionIsolator : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SkinWeightsPaintTool")]
    public class USkinWeightsPaintTool : UDynamicMeshBrushTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}