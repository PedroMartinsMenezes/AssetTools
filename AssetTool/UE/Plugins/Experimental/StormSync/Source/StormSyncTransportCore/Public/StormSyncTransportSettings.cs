namespace AssetTool
{
    [JsonAsset("StormSyncTransportSettings")]
    public class UStormSyncTransportSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}