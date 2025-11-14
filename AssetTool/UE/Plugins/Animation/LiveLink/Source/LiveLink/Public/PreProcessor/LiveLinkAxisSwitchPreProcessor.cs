namespace AssetTool
{
    [JsonAsset("LiveLinkTransformAxisSwitchPreProcessor")]
    public class ULiveLinkTransformAxisSwitchPreProcessor : ULiveLinkFramePreProcessor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LiveLinkAnimationAxisSwitchPreProcessor")]
    public class ULiveLinkAnimationAxisSwitchPreProcessor : ULiveLinkTransformAxisSwitchPreProcessor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}