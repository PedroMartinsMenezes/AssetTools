namespace AssetTool
{
    [JsonAsset("DistributionFloatConstant")]
    public class UDistributionFloatConstant : UDistributionFloat
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}