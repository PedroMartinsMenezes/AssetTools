namespace AssetTool
{
    [JsonAsset("OnlineBeaconUnitTestHost")]
    public class AOnlineBeaconUnitTestHost : AOnlineBeaconHost
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}