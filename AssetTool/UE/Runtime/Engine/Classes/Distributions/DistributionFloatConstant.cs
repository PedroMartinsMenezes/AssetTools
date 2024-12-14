namespace AssetTool
{
    [JsonAsset("DistributionFloatConstant")]
    public class UDistributionFloatConstant : UDistributionFloat
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}