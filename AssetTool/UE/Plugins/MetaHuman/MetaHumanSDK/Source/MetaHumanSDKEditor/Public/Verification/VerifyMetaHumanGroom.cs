namespace AssetTool
{
    [JsonAsset("VerifyMetaHumanGroom")]
    public class UVerifyMetaHumanGroom : UMetaHumanVerificationRuleBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}