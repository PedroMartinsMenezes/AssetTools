namespace AssetTool
{
    [JsonAsset("ScriptableSingleClickTool")]
    public class UScriptableSingleClickTool : UScriptableInteractiveTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}