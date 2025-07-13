namespace AssetTool
{
    [JsonAsset("PartyBeaconState")]
    public class UPartyBeaconState : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}