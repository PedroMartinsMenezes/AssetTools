namespace AssetTool
{
    [JsonAsset("ScriptableToolDoubleClickBehavior")]
    public class UScriptableToolDoubleClickBehavior : UScriptableToolSingleClickBehavior
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}