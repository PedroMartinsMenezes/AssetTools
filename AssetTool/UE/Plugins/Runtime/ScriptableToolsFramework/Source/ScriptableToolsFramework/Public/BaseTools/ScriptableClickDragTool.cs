namespace AssetTool
{
    [JsonAsset("ScriptableClickDragTool")]
    public class UScriptableClickDragTool : UScriptableInteractiveTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}