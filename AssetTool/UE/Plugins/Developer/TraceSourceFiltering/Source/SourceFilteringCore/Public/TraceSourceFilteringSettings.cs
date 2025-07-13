namespace AssetTool
{
    [JsonAsset("TraceSourceFilteringSettings")]
    public class UTraceSourceFilteringSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}