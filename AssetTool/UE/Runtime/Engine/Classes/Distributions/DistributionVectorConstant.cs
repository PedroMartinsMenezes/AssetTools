namespace AssetTool
{
    [JsonAsset("DistributionVectorConstant")]
    public class UDistributionVectorConstant : UDistributionVector
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}