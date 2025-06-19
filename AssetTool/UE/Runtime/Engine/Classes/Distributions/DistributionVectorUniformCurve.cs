namespace AssetTool
{
    [JsonAsset("DistributionVectorUniformCurve")]
    public class UDistributionVectorUniformCurve : UDistributionVector
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}