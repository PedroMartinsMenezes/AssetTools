namespace AssetTool
{
    [JsonAsset("DistributionVectorParameterBase")]
    public class UDistributionVectorParameterBase : UDistributionVectorConstant
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}