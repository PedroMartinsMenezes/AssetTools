namespace AssetTool
{
    [JsonAsset("PartyBeaconHost")]
    public class APartyBeaconHost : AOnlineBeaconHostObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}