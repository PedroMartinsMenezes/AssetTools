namespace AssetTool
{
    [JsonAsset("VerifyObjectValid")]
    public class UVerifyObjectValid : UMetaHumanVerificationRuleBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}