namespace AssetTool
{
    [JsonAsset("ParticleModuleLifetime")]
    public class UParticleModuleLifetime : UParticleModuleLifetimeBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}