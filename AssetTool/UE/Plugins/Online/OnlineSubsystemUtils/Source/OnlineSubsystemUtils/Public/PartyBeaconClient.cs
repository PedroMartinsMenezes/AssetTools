namespace AssetTool
{
    [JsonAsset("PartyBeaconClient")]
    public class APartyBeaconClient : AOnlineBeaconClient
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}