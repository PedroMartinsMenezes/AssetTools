namespace AssetTool
{
    [JsonAsset("PostBufferBlurUpdater")]
    public class UPostBufferBlurUpdater : USlatePostBufferProcessorUpdater
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}