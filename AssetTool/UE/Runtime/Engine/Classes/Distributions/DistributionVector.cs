namespace AssetTool
{
    [JsonAsset("DistributionVector")]
    public class UDistributionVector : UDistribution
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}