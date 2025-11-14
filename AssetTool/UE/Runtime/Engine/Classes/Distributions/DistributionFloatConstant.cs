namespace AssetTool
{
    [JsonAsset("DistributionFloatConstant")]
    public class UDistributionFloatConstant : UDistributionFloat
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}