namespace AssetTool
{
    [JsonAsset("ParticleModuleVelocityOverLifetime")]
    public class UParticleModuleVelocityOverLifetime : UParticleModuleVelocityBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}