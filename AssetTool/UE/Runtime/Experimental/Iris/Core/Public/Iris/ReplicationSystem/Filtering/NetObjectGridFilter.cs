namespace AssetTool
{
    [JsonAsset("NetObjectGridFilterConfig")]
    public class UNetObjectGridFilterConfig : UNetObjectFilterConfig
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NetObjectGridFilter")]
    public class UNetObjectGridFilter : UNetObjectFilter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NetObjectGridWorldLocFilter")]
    public class UNetObjectGridWorldLocFilter : UNetObjectGridFilter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}