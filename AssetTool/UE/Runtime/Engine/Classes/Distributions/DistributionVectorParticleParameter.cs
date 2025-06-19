namespace AssetTool
{
    [JsonAsset("DistributionVectorParticleParameter")]
    public class UDistributionVectorParticleParameter : UDistributionVectorParameterBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}