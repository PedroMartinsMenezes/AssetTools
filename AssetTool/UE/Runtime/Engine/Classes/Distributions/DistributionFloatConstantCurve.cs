namespace AssetTool
{
    [JsonAsset("DistributionFloatConstantCurve")]
    public class UDistributionFloatConstantCurve : UDistributionFloat
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}