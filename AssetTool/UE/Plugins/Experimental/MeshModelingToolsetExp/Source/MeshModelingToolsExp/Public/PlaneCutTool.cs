namespace AssetTool
{
    [JsonAsset("PlaneCutToolBuilder")]
    public class UPlaneCutToolBuilder : UMultiSelectionMeshEditingToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PlaneCutToolProperties")]
    public class UPlaneCutToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PlaneCutOperatorFactory")]
    public class UPlaneCutOperatorFactory : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PlaneCutTool")]
    public class UPlaneCutTool : UMultiSelectionMeshEditingTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}