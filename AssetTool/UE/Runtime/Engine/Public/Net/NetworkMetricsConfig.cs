namespace AssetTool
{
    [JsonAsset("NetworkMetricsConfig")]
    public class UNetworkMetricsConfig : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}