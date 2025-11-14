namespace AssetTool
{
    [JsonAsset("DistributionVectorConstantCurve")]
    public class UDistributionVectorConstantCurve : UDistributionVector
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}