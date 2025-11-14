namespace AssetTool
{
    [JsonAsset("ParticleModuleVelocityOverLifetime")]
    public class UParticleModuleVelocityOverLifetime : UParticleModuleVelocityBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}