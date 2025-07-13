namespace AssetTool
{
    [JsonAsset("CreateWidgetToolBuilder")]
    public class UCreateWidgetToolBuilder : UInteractiveToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CreateWidgetToolProperties")]
    public class UCreateWidgetToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CreateWidgetTool")]
    public class UCreateWidgetTool : USingleClickTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}