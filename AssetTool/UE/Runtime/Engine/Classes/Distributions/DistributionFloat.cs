namespace AssetTool
{
    [JsonAsset("DistributionFloat")]
    public class UDistributionFloat : UDistribution
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}