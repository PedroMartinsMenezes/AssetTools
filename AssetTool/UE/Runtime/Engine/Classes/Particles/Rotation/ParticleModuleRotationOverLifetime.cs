namespace AssetTool
{
    [JsonAsset("ParticleModuleRotationOverLifetime")]
    public class UParticleModuleRotationOverLifetime : UParticleModuleRotationBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}