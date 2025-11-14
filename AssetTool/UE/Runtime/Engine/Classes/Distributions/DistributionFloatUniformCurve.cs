namespace AssetTool
{
    [JsonAsset("DistributionFloatUniformCurve")]
    public class UDistributionFloatUniformCurve : UDistributionFloat
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}