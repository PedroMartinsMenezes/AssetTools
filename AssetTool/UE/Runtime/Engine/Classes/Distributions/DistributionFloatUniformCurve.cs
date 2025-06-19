namespace AssetTool
{
    [JsonAsset("DistributionFloatUniformCurve")]
    public class UDistributionFloatUniformCurve : UDistributionFloat
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}