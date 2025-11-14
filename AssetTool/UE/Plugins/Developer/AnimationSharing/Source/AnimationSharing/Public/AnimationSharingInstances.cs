namespace AssetTool
{
    [JsonAsset("AnimSharingStateInstance")]
    public class UAnimSharingStateInstance : UAnimInstance
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AnimSharingTransitionInstance")]
    public class UAnimSharingTransitionInstance : UAnimInstance
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AnimSharingAdditiveInstance")]
    public class UAnimSharingAdditiveInstance : UAnimInstance
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}