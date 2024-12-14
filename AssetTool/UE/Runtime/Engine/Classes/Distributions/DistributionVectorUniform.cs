namespace AssetTool
{
    [JsonAsset("DistributionVectorUniform")]
    public class UDistributionVectorUniform : UDistributionVector
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}