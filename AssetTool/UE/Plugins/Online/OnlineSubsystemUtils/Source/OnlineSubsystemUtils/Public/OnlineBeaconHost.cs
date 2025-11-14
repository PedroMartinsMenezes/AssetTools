namespace AssetTool
{
    [JsonAsset("OnlineBeaconHost")]
    public class AOnlineBeaconHost : AOnlineBeacon
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}