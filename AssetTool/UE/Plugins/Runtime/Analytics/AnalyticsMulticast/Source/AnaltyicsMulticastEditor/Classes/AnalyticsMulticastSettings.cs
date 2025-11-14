namespace AssetTool
{
    [JsonAsset("AnalyticsMulticastSettings")]
    public class UAnalyticsMulticastSettings : UAnalyticsSettingsBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}