namespace AssetTool
{
    [JsonAsset("BaseMeshProcessingToolBuilder")]
    public class UBaseMeshProcessingToolBuilder : USingleTargetWithSelectionToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("BaseMeshProcessingTool")]
    public class UBaseMeshProcessingTool : USingleTargetWithSelectionTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}