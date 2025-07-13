namespace AssetTool
{
    [JsonAsset("OnlineBeaconClient")]
    public class AOnlineBeaconClient : AOnlineBeacon
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}