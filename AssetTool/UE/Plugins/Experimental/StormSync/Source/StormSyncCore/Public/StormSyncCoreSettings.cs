namespace AssetTool
{
    [JsonAsset("StormSyncCoreSettings")]
    public class UStormSyncCoreSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}