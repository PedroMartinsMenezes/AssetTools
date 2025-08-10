namespace AssetTool
{
    [JsonAsset("MetaHumanCharacterAnimInstance")]
    public class UMetaHumanCharacterAnimInstance : UAnimInstance
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}