namespace AssetTool
{
    [JsonAsset("OnlineBeaconUnitTestClient")]
    public class AOnlineBeaconUnitTestClient : AOnlineBeaconClient
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}