namespace AssetTool
{
    [JsonAsset("ScriptableSingleClickTool")]
    public class UScriptableSingleClickTool : UScriptableInteractiveTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}