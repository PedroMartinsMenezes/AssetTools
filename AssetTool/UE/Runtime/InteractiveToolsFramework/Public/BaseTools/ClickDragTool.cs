namespace AssetTool
{
    [JsonAsset("ClickDragToolBuilder")]
    public class UClickDragToolBuilder : UInteractiveToolBuilder
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ClickDragTool")]
    public class UClickDragTool : UInteractiveTool
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}