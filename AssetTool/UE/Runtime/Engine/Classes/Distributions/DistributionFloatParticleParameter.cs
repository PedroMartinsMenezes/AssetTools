namespace AssetTool
{
    [JsonAsset("DistributionFloatParticleParameter")]
    public class UDistributionFloatParticleParameter : UDistributionFloatParameterBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}