namespace AssetTool
{
    [JsonAsset("LODManagerToolBuilder")]
    public class ULODManagerToolBuilder : UMultiSelectionMeshEditingToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LODManagerLODProperties")]
    public class ULODManagerLODProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LODManagerPreviewLODProperties")]
    public class ULODManagerPreviewLODProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LODManagerActionPropertySet")]
    public class ULODManagerActionPropertySet : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LODManagerHiResSourceModelActions")]
    public class ULODManagerHiResSourceModelActions : ULODManagerActionPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LODManagerMaterialActions")]
    public class ULODManagerMaterialActions : ULODManagerActionPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LODManagerTool")]
    public class ULODManagerTool : UMultiSelectionMeshEditingTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}