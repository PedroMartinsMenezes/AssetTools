namespace AssetTool
{
    [JsonAsset("LiveLinkTransformDeadbandPreProcessor")]
    public class ULiveLinkTransformDeadbandPreProcessor : ULiveLinkFramePreProcessor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}