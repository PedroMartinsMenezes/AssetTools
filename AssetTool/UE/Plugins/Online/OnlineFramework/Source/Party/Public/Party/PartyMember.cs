namespace AssetTool
{
    [JsonAsset("PartyMember")]
    public class UPartyMember : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}