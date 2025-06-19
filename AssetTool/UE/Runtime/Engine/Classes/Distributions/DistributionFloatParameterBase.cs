namespace AssetTool
{
    [JsonAsset("DistributionFloatParameterBase")]
    public class UDistributionFloatParameterBase : UDistributionFloatConstant
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}