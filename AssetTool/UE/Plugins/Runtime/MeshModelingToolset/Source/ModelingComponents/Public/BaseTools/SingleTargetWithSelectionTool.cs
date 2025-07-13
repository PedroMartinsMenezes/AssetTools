namespace AssetTool
{
    [JsonAsset("SingleTargetWithSelectionToolBuilder")]
    public class USingleTargetWithSelectionToolBuilder : UInteractiveToolWithToolTargetsBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SingleTargetWithSelectionTool")]
    public class USingleTargetWithSelectionTool : USingleSelectionTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}