namespace AssetTool
{
    [JsonAsset("ScriptableToolDoubleClickBehavior")]
    public class UScriptableToolDoubleClickBehavior : UScriptableToolSingleClickBehavior
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}