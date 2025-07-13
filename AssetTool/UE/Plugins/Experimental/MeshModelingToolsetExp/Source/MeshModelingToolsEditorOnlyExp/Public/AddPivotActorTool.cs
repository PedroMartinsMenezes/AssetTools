namespace AssetTool
{
    [JsonAsset("PivotActorTransformProperties")]
    public class UPivotActorTransformProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AddPivotActorToolBuilder")]
    public class UAddPivotActorToolBuilder : UMultiSelectionMeshEditingToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AddPivotActorTool")]
    public class UAddPivotActorTool : UMultiSelectionMeshEditingTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}