namespace AssetTool
{
    [JsonAsset("PartyBeaconState")]
    public class UPartyBeaconState : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}