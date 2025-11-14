namespace AssetTool
{
    [JsonAsset("EditorKeyboardShortcutSettings")]
    public class UEditorKeyboardShortcutSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}