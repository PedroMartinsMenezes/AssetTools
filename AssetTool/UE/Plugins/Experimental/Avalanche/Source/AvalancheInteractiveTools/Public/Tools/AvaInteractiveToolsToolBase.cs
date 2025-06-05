namespace AssetTool
{
    [JsonAsset("AvaInteractiveToolsRightClickBehavior")]
    public class UAvaInteractiveToolsRightClickBehavior : USingleClickInputBehavior
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AvaInteractiveToolsToolBase")]
    public class UAvaInteractiveToolsToolBase : UInteractiveTool
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}