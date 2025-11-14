namespace AssetTool
{
    [JsonAsset("ScriptableToolSingleClickOrDragBehavior")]
    public class UScriptableToolSingleClickOrDragBehavior : UScriptableToolBehavior
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}