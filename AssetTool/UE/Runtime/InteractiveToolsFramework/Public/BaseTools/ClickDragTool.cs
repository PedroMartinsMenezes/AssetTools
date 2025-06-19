namespace AssetTool
{
    [JsonAsset("ClickDragToolBuilder")]
    public class UClickDragToolBuilder : UInteractiveToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ClickDragTool")]
    public class UClickDragTool : UInteractiveTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}