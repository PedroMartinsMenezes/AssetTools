namespace AssetTool
{
    [JsonAsset("AnimSharingInstance")]
    public class UAnimSharingInstance : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AnimationSharingManager")]
    public class UAnimationSharingManager : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}