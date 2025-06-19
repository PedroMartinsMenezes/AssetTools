namespace AssetTool
{
    [JsonAsset("DistributionFloatConstantCurve")]
    public class UDistributionFloatConstantCurve : UDistributionFloat
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}