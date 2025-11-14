namespace AssetTool
{
    [JsonAsset("MeasureDistanceSampleToolBuilder")]
    public class UMeasureDistanceSampleToolBuilder : UInteractiveToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeasureDistanceProperties")]
    public class UMeasureDistanceProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeasureDistanceSampleTool")]
    public class UMeasureDistanceSampleTool : UInteractiveTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}