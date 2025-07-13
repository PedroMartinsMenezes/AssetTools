namespace AssetTool
{
    [JsonAsset("DisplayClusterStageMonitoringSettings")]
    public class UDisplayClusterStageMonitoringSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}