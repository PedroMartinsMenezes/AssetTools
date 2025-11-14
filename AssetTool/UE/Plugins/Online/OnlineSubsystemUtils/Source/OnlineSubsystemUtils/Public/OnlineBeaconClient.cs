namespace AssetTool
{
    [JsonAsset("OnlineBeaconClient")]
    public class AOnlineBeaconClient : AOnlineBeacon
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}