namespace AssetTool
{
    [JsonAsset("DistributionFloatUniform")]
    public class UDistributionFloatUniform : UDistributionFloat
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}