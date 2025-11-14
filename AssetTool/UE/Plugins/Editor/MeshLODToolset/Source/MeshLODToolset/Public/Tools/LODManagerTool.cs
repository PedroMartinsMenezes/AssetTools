namespace AssetTool
{
    [JsonAsset("LODManagerToolBuilder")]
    public class ULODManagerToolBuilder : UMultiSelectionMeshEditingToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LODManagerLODProperties")]
    public class ULODManagerLODProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LODManagerPreviewLODProperties")]
    public class ULODManagerPreviewLODProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LODManagerActionPropertySet")]
    public class ULODManagerActionPropertySet : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LODManagerHiResSourceModelActions")]
    public class ULODManagerHiResSourceModelActions : ULODManagerActionPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LODManagerMaterialActions")]
    public class ULODManagerMaterialActions : ULODManagerActionPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LODManagerTool")]
    public class ULODManagerTool : UMultiSelectionMeshEditingTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}