namespace AssetTool
{
    [JsonAsset("ParticleModuleRotationRate")]
    public class UParticleModuleRotationRate : UParticleModuleRotationRateBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}