namespace AssetTool
{
    [JsonAsset("AdjustSettings")]
    public class UAdjustSettings : UAnalyticsSettingsBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}