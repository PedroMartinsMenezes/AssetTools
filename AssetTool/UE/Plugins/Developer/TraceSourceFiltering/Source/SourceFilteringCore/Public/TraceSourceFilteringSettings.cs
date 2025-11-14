namespace AssetTool
{
    [JsonAsset("TraceSourceFilteringSettings")]
    public class UTraceSourceFilteringSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}