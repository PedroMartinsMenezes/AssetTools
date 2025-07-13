namespace AssetTool
{
    [JsonAsset("StageMonitoringSettings")]
    public class UStageMonitoringSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}