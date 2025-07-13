namespace AssetTool
{
    [JsonAsset("EditorScriptableInteractiveTool")]
    public class UEditorScriptableInteractiveTool : UScriptableInteractiveTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EditorScriptableInteractiveToolPropertySet")]
    public class UEditorScriptableInteractiveToolPropertySet : UScriptableInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}