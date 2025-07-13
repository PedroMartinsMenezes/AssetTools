namespace AssetTool
{
    [JsonAsset("MockNetObjectFilterConfig")]
    public class UMockNetObjectFilterConfig : UNetObjectFilterConfig
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MockNetObjectFilter")]
    public class UMockNetObjectFilter : UNetObjectFilter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MockNetObjectFilterWithCondition")]
    public class UMockNetObjectFilterWithCondition : UMockNetObjectFilter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}