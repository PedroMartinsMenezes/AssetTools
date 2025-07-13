namespace AssetTool
{
    [JsonAsset("NetObjectFilterConfig")]
    public class UNetObjectFilterConfig : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NetObjectFilter")]
    public class UNetObjectFilter : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}