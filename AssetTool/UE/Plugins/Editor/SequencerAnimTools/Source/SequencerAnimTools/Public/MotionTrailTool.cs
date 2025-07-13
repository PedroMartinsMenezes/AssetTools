namespace AssetTool
{
    [JsonAsset("MotionTrailToolBuilder")]
    public class UMotionTrailToolBuilder : UInteractiveToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MotionTrailTool")]
    public class UMotionTrailTool : UMultiSelectionTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}