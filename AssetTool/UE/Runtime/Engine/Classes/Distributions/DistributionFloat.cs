namespace AssetTool
{
    [JsonAsset("DistributionFloat")]
    public class UDistributionFloat : UDistribution
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}