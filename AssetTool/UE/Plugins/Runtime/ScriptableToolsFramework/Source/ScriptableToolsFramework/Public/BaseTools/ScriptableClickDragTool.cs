namespace AssetTool
{
    [JsonAsset("ScriptableClickDragTool")]
    public class UScriptableClickDragTool : UScriptableInteractiveTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}