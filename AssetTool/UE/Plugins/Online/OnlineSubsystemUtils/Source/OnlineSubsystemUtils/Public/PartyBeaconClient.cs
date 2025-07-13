namespace AssetTool
{
    [JsonAsset("PartyBeaconClient")]
    public class APartyBeaconClient : AOnlineBeaconClient
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}