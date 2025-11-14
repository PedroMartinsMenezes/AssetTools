namespace AssetTool
{
    [JsonAsset("DistributionVectorUniformCurve")]
    public class UDistributionVectorUniformCurve : UDistributionVector
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}