namespace AssetTool
{
    [JsonAsset("RectangleSelectToolBuilder")]
    public class URectangleSelectToolBuilder : UInteractiveToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RectangleSelectProperties")]
    public class URectangleSelectProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RectangleSelectTool")]
    public class URectangleSelectTool : UInteractiveTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}