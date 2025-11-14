namespace AssetTool
{
    [JsonAsset("AvaInteractiveToolsRightClickBehavior")]
    public class UAvaInteractiveToolsRightClickBehavior : USingleClickInputBehavior
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AvaInteractiveToolsToolBase")]
    public class UAvaInteractiveToolsToolBase : UInteractiveTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}