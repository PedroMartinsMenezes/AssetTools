namespace AssetTool
{
    [JsonAsset("WidgetEditingProjectSettings")]
    public class UWidgetEditingProjectSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}