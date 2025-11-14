namespace AssetTool
{
    [JsonAsset("MotionTrailToolBuilder")]
    public class UMotionTrailToolBuilder : UInteractiveToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MotionTrailTool")]
    public class UMotionTrailTool : UMultiSelectionTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}