namespace AssetTool
{
    [JsonAsset("MetaHumanVerificationRuleBase")]
    public class UMetaHumanVerificationRuleBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanVerificationRuleCollection")]
    public class UMetaHumanVerificationRuleCollection : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}