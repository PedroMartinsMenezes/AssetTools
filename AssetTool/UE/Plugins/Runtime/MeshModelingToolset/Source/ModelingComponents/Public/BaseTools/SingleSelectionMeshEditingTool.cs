namespace AssetTool
{
    [JsonAsset("SingleSelectionMeshEditingToolBuilder")]
    public class USingleSelectionMeshEditingToolBuilder : UInteractiveToolWithToolTargetsBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SingleSelectionMeshEditingTool")]
    public class USingleSelectionMeshEditingTool : USingleSelectionTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}