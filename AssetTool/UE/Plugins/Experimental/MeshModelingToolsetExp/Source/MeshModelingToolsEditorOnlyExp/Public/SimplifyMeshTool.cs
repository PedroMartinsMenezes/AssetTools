namespace AssetTool
{
    [JsonAsset("SimplifyMeshToolBuilder")]
    public class USimplifyMeshToolBuilder : USingleSelectionMeshEditingToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SimplifyMeshToolProperties")]
    public class USimplifyMeshToolProperties : UMeshConstraintProperties
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SimplifyMeshTool")]
    public class USimplifyMeshTool : USingleSelectionMeshEditingTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}