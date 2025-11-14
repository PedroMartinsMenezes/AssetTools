namespace AssetTool
{
    [JsonAsset("OnlineBeaconUnitTestHost")]
    public class AOnlineBeaconUnitTestHost : AOnlineBeaconHost
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}