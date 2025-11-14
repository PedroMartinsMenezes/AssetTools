namespace AssetTool
{
    [JsonAsset("DistributionVectorUniform")]
    public class UDistributionVectorUniform : UDistributionVector
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}