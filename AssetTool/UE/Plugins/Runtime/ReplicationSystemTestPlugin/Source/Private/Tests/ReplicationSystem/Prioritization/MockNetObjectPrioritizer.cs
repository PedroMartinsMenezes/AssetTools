namespace AssetTool
{
    [JsonAsset("MockNetObjectPrioritizerConfig")]
    public class UMockNetObjectPrioritizerConfig : UNetObjectPrioritizerConfig
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MockNetObjectPrioritizer")]
    public class UMockNetObjectPrioritizer : UNetObjectPrioritizer
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}