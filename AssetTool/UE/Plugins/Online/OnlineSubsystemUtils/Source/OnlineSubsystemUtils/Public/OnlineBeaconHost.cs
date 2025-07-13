namespace AssetTool
{
    [JsonAsset("OnlineBeaconHost")]
    public class AOnlineBeaconHost : AOnlineBeacon
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}