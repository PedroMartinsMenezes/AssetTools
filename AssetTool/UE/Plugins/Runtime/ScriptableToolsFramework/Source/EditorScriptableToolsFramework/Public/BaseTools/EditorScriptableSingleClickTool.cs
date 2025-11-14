namespace AssetTool
{
    [JsonAsset("EditorScriptableSingleClickTool")]
    public class UEditorScriptableSingleClickTool : UScriptableSingleClickTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}