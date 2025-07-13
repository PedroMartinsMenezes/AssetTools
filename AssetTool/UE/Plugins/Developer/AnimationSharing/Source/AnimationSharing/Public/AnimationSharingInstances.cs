namespace AssetTool
{
    [JsonAsset("AnimSharingStateInstance")]
    public class UAnimSharingStateInstance : UAnimInstance
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AnimSharingTransitionInstance")]
    public class UAnimSharingTransitionInstance : UAnimInstance
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AnimSharingAdditiveInstance")]
    public class UAnimSharingAdditiveInstance : UAnimInstance
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}