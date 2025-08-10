namespace AssetTool
{
    [JsonAsset("VerifyMetaHumanOutfitClothing")]
    public class UVerifyMetaHumanOutfitClothing : UMetaHumanVerificationRuleBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}