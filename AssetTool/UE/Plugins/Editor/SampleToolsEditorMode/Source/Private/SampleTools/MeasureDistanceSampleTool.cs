namespace AssetTool
{
    [JsonAsset("MeasureDistanceSampleToolBuilder")]
    public class UMeasureDistanceSampleToolBuilder : UInteractiveToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeasureDistanceProperties")]
    public class UMeasureDistanceProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeasureDistanceSampleTool")]
    public class UMeasureDistanceSampleTool : UInteractiveTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}