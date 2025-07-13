namespace AssetTool
{
    [JsonAsset("MultiTargetWithSelectionToolBuilder")]
    public class UMultiTargetWithSelectionToolBuilder : UInteractiveToolWithToolTargetsBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MultiTargetWithSelectionTool")]
    public class UMultiTargetWithSelectionTool : UMultiSelectionTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}