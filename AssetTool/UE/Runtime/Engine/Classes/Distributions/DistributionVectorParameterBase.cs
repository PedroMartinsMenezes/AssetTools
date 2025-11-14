namespace AssetTool
{
    [JsonAsset("DistributionVectorParameterBase")]
    public class UDistributionVectorParameterBase : UDistributionVectorConstant
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}