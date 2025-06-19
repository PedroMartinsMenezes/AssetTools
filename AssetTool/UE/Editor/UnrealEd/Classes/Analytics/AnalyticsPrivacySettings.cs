namespace AssetTool
{
    [JsonAsset("AnalyticsPrivacySettings")]
    public class UAnalyticsPrivacySettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}