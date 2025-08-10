namespace AssetTool
{
    [JsonAsset("VerifyMetaHumanPackageSource")]
    public class UVerifyMetaHumanPackageSource : UMetaHumanVerificationRuleBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}