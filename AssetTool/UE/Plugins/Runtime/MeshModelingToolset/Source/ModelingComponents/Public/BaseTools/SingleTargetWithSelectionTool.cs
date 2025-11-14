namespace AssetTool
{
    [JsonAsset("SingleTargetWithSelectionToolBuilder")]
    public class USingleTargetWithSelectionToolBuilder : UInteractiveToolWithToolTargetsBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SingleTargetWithSelectionTool")]
    public class USingleTargetWithSelectionTool : USingleSelectionTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}