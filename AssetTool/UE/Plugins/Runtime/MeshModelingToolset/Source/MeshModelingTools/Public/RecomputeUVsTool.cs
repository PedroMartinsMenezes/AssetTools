namespace AssetTool
{
    [JsonAsset("RecomputeUVsToolBuilder")]
    public class URecomputeUVsToolBuilder : USingleSelectionMeshEditingToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RecomputeUVsTool")]
    public class URecomputeUVsTool : USingleSelectionMeshEditingTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}