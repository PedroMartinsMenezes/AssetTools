namespace AssetTool
{
    [JsonAsset("PostBufferBlurUpdater")]
    public class UPostBufferBlurUpdater : USlatePostBufferProcessorUpdater
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}