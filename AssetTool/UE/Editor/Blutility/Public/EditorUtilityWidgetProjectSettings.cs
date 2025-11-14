namespace AssetTool
{
    [JsonAsset("EditorUtilityWidgetProjectSettings")]
    public class UEditorUtilityWidgetProjectSettings : UWidgetEditingProjectSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}