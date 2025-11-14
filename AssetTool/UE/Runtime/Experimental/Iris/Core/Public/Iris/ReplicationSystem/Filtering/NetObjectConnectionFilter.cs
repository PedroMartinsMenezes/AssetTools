namespace AssetTool
{
    [JsonAsset("NetObjectConnectionFilterConfig")]
    public class UNetObjectConnectionFilterConfig : UNetObjectFilterConfig
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NetObjectConnectionFilter")]
    public class UNetObjectConnectionFilter : UNetObjectFilter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}