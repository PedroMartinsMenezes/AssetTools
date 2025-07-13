namespace AssetTool
{
    [JsonAsset("ScriptableToolSingleClickBehavior")]
    public class UScriptableToolSingleClickBehavior : UScriptableToolBehavior
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}