namespace AssetTool
{
    [JsonAsset("MultiSelectionMeshEditingToolBuilder")]
    public class UMultiSelectionMeshEditingToolBuilder : UInteractiveToolWithToolTargetsBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MultiSelectionMeshEditingTool")]
    public class UMultiSelectionMeshEditingTool : UMultiSelectionTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}