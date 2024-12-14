namespace AssetTool
{
    [JsonAsset("DistributionFloatParameterBase")]
    public class UDistributionFloatParameterBase : UDistributionFloatConstant
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}