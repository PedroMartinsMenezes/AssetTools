namespace AssetTool
{
    [JsonAsset("NopNetObjectFilterConfig")]
    public class UNopNetObjectFilterConfig : UNetObjectFilterConfig
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NopNetObjectFilter")]
    public class UNopNetObjectFilter : UNetObjectFilter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}