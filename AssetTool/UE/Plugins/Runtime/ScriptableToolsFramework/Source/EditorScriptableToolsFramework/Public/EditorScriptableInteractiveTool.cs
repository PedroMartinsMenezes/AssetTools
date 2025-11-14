namespace AssetTool
{
    [JsonAsset("EditorScriptableInteractiveTool")]
    public class UEditorScriptableInteractiveTool : UScriptableInteractiveTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EditorScriptableInteractiveToolPropertySet")]
    public class UEditorScriptableInteractiveToolPropertySet : UScriptableInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}