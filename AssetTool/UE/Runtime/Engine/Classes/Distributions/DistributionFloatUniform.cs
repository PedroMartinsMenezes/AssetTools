namespace AssetTool
{
    [JsonAsset("DistributionFloatUniform")]
    public class UDistributionFloatUniform : UDistributionFloat
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}