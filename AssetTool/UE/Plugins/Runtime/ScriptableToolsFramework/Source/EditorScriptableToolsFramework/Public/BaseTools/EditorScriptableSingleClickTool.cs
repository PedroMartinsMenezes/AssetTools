namespace AssetTool
{
    [JsonAsset("EditorScriptableSingleClickTool")]
    public class UEditorScriptableSingleClickTool : UScriptableSingleClickTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}