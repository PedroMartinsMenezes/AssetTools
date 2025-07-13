namespace AssetTool
{
    [JsonAsset("AnimationSharingSetup")]
    public class UAnimationSharingSetup : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}