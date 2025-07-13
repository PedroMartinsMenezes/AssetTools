namespace AssetTool
{
    [JsonAsset("SingleSelectionMeshEditingToolBuilder")]
    public class USingleSelectionMeshEditingToolBuilder : UInteractiveToolWithToolTargetsBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SingleSelectionMeshEditingTool")]
    public class USingleSelectionMeshEditingTool : USingleSelectionTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}