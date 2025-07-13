namespace AssetTool
{
    [JsonAsset("TraceSourceFilteringProjectSettings")]
    public class UTraceSourceFilteringProjectSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}