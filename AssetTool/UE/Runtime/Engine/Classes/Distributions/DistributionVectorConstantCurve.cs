namespace AssetTool
{
    [JsonAsset("DistributionVectorConstantCurve")]
    public class UDistributionVectorConstantCurve : UDistributionVector
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}