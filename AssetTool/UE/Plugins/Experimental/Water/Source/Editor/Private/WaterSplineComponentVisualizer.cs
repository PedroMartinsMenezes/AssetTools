namespace AssetTool
{
    [JsonAsset("WaterSplineComponentVisualizerSelectionState")]
    public class UWaterSplineComponentVisualizerSelectionState : USplineComponentVisualizerSelectionState
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}