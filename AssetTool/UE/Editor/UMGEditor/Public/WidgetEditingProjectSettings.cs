namespace AssetTool
{
    [JsonAsset("WidgetEditingProjectSettings")]
    public class UWidgetEditingProjectSettings : UDeveloperSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}