namespace AssetTool
{
    [JsonAsset("PostBufferUpdate")]
    public class UPostBufferUpdate : UWidget
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SlatePostBufferProcessorUpdater")]
    public class USlatePostBufferProcessorUpdater : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}