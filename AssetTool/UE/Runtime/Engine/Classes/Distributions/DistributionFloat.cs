namespace AssetTool
{
    [JsonAsset("DistributionFloat")]
    public class UDistributionFloat : UDistribution
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}