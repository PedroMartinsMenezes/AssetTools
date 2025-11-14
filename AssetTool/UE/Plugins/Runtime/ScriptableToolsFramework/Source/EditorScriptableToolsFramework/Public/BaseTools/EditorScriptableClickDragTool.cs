namespace AssetTool
{
    [JsonAsset("EditorScriptableClickDragTool")]
    public class UEditorScriptableClickDragTool : UScriptableClickDragTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}