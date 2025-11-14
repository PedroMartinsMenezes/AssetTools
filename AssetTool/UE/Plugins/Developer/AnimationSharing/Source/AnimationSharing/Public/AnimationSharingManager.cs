namespace AssetTool
{
    [JsonAsset("AnimSharingInstance")]
    public class UAnimSharingInstance : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AnimationSharingManager")]
    public class UAnimationSharingManager : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}