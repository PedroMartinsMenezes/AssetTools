namespace AssetTool
{
    [JsonAsset("DistributionVectorConstantCurve")]
    public class UDistributionVectorConstantCurve : UDistributionVector
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}