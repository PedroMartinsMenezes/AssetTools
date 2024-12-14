namespace AssetTool
{
    [JsonAsset("DistributionVector")]
    public class UDistributionVector : UDistribution
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}