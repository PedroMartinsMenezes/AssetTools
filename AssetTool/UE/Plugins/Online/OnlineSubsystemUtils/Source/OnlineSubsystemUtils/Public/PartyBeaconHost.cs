namespace AssetTool
{
    [JsonAsset("PartyBeaconHost")]
    public class APartyBeaconHost : AOnlineBeaconHostObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}