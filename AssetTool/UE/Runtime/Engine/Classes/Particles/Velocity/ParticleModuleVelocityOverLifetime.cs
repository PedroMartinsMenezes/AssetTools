namespace AssetTool
{
    [JsonAsset("ParticleModuleVelocityOverLifetime")]
    public class UParticleModuleVelocityOverLifetime : UParticleModuleVelocityBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}