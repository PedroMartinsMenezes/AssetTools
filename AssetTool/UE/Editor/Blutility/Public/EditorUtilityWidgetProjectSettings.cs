namespace AssetTool
{
    [JsonAsset("EditorUtilityWidgetProjectSettings")]
    public class UEditorUtilityWidgetProjectSettings : UWidgetEditingProjectSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}