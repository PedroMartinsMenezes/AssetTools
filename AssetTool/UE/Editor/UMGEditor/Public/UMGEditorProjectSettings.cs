namespace AssetTool
{
    [JsonAsset("UMGEditorProjectSettings")]
    public class UUMGEditorProjectSettings : UWidgetEditingProjectSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}