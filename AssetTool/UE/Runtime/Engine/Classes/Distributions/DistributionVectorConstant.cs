namespace AssetTool
{
    [JsonAsset("DistributionVectorConstant")]
    public class UDistributionVectorConstant : UDistributionVector
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}