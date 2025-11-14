namespace AssetTool
{
    [JsonAsset("DistributionFloatUniform")]
    public class UDistributionFloatUniform : UDistributionFloat
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}