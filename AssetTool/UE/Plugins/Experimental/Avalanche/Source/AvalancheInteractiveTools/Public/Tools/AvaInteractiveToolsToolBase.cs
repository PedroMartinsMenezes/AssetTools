namespace AssetTool
{
    [JsonAsset("AvaInteractiveToolsRightClickBehavior")]
    public class UAvaInteractiveToolsRightClickBehavior : USingleClickInputBehavior
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AvaInteractiveToolsToolBase")]
    public class UAvaInteractiveToolsToolBase : UInteractiveTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}