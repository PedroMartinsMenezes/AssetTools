namespace AssetTool
{
    [JsonAsset("DistributionVectorUniform")]
    public class UDistributionVectorUniform : UDistributionVector
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}