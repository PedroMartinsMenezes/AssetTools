namespace AssetTool
{
    [JsonAsset("OnlineBeaconUnitTestClient")]
    public class AOnlineBeaconUnitTestClient : AOnlineBeaconClient
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}