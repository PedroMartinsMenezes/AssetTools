namespace AssetTool
{
    [JsonAsset("ParticleModuleRotationOverLifetime")]
    public class UParticleModuleRotationOverLifetime : UParticleModuleRotationBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}