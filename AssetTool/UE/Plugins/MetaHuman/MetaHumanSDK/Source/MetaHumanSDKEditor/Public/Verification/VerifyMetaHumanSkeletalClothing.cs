namespace AssetTool
{
    [JsonAsset("VerifyMetaHumanSkeletalClothing")]
    public class UVerifyMetaHumanSkeletalClothing : UMetaHumanVerificationRuleBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}