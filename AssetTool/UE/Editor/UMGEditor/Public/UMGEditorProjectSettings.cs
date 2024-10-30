namespace AssetTool
{
    [JsonAsset("UMGEditorProjectSettings")]
    public class UUMGEditorProjectSettings : UWidgetEditingProjectSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}