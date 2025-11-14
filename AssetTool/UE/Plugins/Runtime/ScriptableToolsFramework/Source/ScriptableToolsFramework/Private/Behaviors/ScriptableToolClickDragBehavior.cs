namespace AssetTool
{
    [JsonAsset("ScriptableToolClickDragBehavior")]
    public class UScriptableToolClickDragBehavior : UScriptableToolBehavior
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}