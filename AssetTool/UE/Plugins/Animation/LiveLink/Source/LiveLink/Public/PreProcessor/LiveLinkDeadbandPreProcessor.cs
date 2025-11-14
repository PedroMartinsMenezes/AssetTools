namespace AssetTool
{
    [JsonAsset("LiveLinkTransformDeadbandPreProcessor")]
    public class ULiveLinkTransformDeadbandPreProcessor : ULiveLinkFramePreProcessor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}