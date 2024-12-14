namespace AssetTool
{
    [JsonAsset("DistributionVectorConstant")]
    public class UDistributionVectorConstant : UDistributionVector
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}