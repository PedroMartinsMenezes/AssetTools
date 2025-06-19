namespace AssetTool
{
    [JsonAsset("DistributionVectorParameterBase")]
    public class UDistributionVectorParameterBase : UDistributionVectorConstant
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}