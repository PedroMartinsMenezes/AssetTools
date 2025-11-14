namespace AssetTool
{
    [JsonAsset("PartyMember")]
    public class UPartyMember : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}