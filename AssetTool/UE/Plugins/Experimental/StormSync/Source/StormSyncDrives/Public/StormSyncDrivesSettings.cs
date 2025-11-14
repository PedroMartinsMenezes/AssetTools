namespace AssetTool
{
    [JsonAsset("StormSyncDrivesSettings")]
    public class UStormSyncDrivesSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}