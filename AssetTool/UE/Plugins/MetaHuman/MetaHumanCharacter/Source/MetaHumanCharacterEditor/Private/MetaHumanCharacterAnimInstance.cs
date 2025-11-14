namespace AssetTool
{
    [JsonAsset("MetaHumanCharacterAnimInstance")]
    public class UMetaHumanCharacterAnimInstance : UAnimInstance
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}