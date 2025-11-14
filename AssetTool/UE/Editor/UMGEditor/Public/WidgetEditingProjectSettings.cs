namespace AssetTool
{
    [JsonAsset("WidgetEditingProjectSettings")]
    public class UWidgetEditingProjectSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}