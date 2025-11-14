namespace AssetTool
{
    [JsonAsset("DistributionVector")]
    public class UDistributionVector : UDistribution
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}