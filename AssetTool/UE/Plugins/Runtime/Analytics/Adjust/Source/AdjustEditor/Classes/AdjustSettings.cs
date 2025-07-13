namespace AssetTool
{
    [JsonAsset("AdjustSettings")]
    public class UAdjustSettings : UAnalyticsSettingsBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}