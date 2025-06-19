namespace AssetTool
{
    [JsonAsset("UMGEditorProjectSettings")]
    public class UUMGEditorProjectSettings : UWidgetEditingProjectSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}