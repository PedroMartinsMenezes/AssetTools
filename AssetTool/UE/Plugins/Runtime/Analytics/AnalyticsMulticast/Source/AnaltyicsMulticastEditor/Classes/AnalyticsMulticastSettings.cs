namespace AssetTool
{
    [JsonAsset("AnalyticsMulticastSettings")]
    public class UAnalyticsMulticastSettings : UAnalyticsSettingsBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}