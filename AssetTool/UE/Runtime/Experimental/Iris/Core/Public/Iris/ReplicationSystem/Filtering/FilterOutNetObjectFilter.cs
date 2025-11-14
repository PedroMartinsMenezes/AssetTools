namespace AssetTool
{
    [JsonAsset("FilterOutNetObjectFilterConfig")]
    public class UFilterOutNetObjectFilterConfig : UNetObjectFilterConfig
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FilterOutNetObjectFilter")]
    public class UFilterOutNetObjectFilter : UNetObjectFilter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}