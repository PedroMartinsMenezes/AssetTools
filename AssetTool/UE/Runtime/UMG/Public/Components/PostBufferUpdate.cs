namespace AssetTool
{
    [JsonAsset("PostBufferUpdate")]
    public class UPostBufferUpdate : UWidget
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SlatePostBufferProcessorUpdater")]
    public class USlatePostBufferProcessorUpdater : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}