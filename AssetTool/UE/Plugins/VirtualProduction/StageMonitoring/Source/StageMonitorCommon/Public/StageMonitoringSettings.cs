namespace AssetTool
{
    [JsonAsset("StageMonitoringSettings")]
    public class UStageMonitoringSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}