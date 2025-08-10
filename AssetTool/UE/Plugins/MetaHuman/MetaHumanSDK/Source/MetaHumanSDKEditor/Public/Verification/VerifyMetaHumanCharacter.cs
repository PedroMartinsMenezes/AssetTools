namespace AssetTool
{
    [JsonAsset("VerifyMetaHumanCharacter")]
    public class UVerifyMetaHumanCharacter : UMetaHumanVerificationRuleBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}