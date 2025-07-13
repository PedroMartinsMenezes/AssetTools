namespace AssetTool
{
    [JsonAsset("FlurrySettings")]
    public class UFlurrySettings : UAnalyticsSettingsBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}