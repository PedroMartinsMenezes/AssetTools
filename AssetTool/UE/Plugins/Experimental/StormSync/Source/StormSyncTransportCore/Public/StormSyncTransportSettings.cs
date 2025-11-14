namespace AssetTool
{
    [JsonAsset("StormSyncTransportSettings")]
    public class UStormSyncTransportSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}