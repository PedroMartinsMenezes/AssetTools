namespace AssetTool
{
    [JsonAsset("AnalyticsSettingsBase")]
    public class UAnalyticsSettingsBase : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AnalyticsSettings")]
    public class UAnalyticsSettings : UAnalyticsSettingsBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}