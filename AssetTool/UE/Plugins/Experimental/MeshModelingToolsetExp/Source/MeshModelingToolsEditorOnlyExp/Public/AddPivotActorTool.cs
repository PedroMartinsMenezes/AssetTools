namespace AssetTool
{
    [JsonAsset("PivotActorTransformProperties")]
    public class UPivotActorTransformProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AddPivotActorToolBuilder")]
    public class UAddPivotActorToolBuilder : UMultiSelectionMeshEditingToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AddPivotActorTool")]
    public class UAddPivotActorTool : UMultiSelectionMeshEditingTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}