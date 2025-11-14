namespace AssetTool
{
    [JsonAsset("StormSyncCoreSettings")]
    public class UStormSyncCoreSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}