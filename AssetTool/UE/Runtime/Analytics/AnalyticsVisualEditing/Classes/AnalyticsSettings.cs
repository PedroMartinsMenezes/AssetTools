namespace AssetTool
{
    [JsonAsset("AnalyticsSettingsBase")]
    public class UAnalyticsSettingsBase : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AnalyticsSettings")]
    public class UAnalyticsSettings : UAnalyticsSettingsBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}