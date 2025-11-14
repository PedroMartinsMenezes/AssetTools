namespace AssetTool
{
    [JsonAsset("DistributionFloatParameterBase")]
    public class UDistributionFloatParameterBase : UDistributionFloatConstant
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}