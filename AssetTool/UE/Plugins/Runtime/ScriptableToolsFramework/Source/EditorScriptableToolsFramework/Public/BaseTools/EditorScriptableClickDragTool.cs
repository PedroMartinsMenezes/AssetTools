namespace AssetTool
{
    [JsonAsset("EditorScriptableClickDragTool")]
    public class UEditorScriptableClickDragTool : UScriptableClickDragTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}