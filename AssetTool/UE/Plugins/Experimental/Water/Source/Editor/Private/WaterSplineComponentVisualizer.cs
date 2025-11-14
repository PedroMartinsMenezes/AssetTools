namespace AssetTool
{
    [JsonAsset("WaterSplineComponentVisualizerSelectionState")]
    public class UWaterSplineComponentVisualizerSelectionState : USplineComponentVisualizerSelectionState
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}