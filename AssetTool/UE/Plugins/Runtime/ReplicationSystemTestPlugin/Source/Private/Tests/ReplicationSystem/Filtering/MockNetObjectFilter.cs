namespace AssetTool
{
    [JsonAsset("MockNetObjectFilterConfig")]
    public class UMockNetObjectFilterConfig : UNetObjectFilterConfig
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MockNetObjectFilter")]
    public class UMockNetObjectFilter : UNetObjectFilter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MockNetObjectFilterWithCondition")]
    public class UMockNetObjectFilterWithCondition : UMockNetObjectFilter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}