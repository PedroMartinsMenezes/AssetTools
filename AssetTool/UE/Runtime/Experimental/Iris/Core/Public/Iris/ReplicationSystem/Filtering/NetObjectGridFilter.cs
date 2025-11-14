namespace AssetTool
{
    [JsonAsset("NetObjectGridFilterConfig")]
    public class UNetObjectGridFilterConfig : UNetObjectFilterConfig
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NetObjectGridFilter")]
    public class UNetObjectGridFilter : UNetObjectFilter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NetObjectGridWorldLocFilter")]
    public class UNetObjectGridWorldLocFilter : UNetObjectGridFilter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}