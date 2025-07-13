namespace AssetTool
{
    [JsonAsset("NetworkMetricsDatabase")]
    public class UNetworkMetricsDatabase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NetworkMetricsBaseListener")]
    public class UNetworkMetricsBaseListener : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NetworkMetricsCSV")]
    public class UNetworkMetricsCSV : UNetworkMetricsBaseListener
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NetworkMetricsPerfCounters")]
    public class UNetworkMetricsPerfCounters : UNetworkMetricsBaseListener
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NetworkMetricsStats")]
    public class UNetworkMetricsStats : UNetworkMetricsBaseListener
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}