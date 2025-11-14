namespace AssetTool
{
    [JsonAsset("AnimationSharingSetup")]
    public class UAnimationSharingSetup : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}