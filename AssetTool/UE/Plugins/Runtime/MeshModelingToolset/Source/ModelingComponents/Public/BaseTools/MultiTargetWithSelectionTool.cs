namespace AssetTool
{
    [JsonAsset("MultiTargetWithSelectionToolBuilder")]
    public class UMultiTargetWithSelectionToolBuilder : UInteractiveToolWithToolTargetsBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MultiTargetWithSelectionTool")]
    public class UMultiTargetWithSelectionTool : UMultiSelectionTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}