namespace AssetTool
{
    [JsonAsset("LiveLinkTransformAxisSwitchPreProcessor")]
    public class ULiveLinkTransformAxisSwitchPreProcessor : ULiveLinkFramePreProcessor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LiveLinkAnimationAxisSwitchPreProcessor")]
    public class ULiveLinkAnimationAxisSwitchPreProcessor : ULiveLinkTransformAxisSwitchPreProcessor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}