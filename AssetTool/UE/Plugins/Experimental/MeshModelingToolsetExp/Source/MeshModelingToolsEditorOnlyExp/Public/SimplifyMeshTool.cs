namespace AssetTool
{
    [JsonAsset("SimplifyMeshToolBuilder")]
    public class USimplifyMeshToolBuilder : USingleSelectionMeshEditingToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SimplifyMeshToolProperties")]
    public class USimplifyMeshToolProperties : UMeshConstraintProperties
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SimplifyMeshTool")]
    public class USimplifyMeshTool : USingleSelectionMeshEditingTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}