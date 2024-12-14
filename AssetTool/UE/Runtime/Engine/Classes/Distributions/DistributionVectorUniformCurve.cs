namespace AssetTool
{
    [JsonAsset("DistributionVectorUniformCurve")]
    public class UDistributionVectorUniformCurve : UDistributionVector
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}