namespace AssetTool
{
    [JsonAsset("ParticleModuleLifetime")]
    public class UParticleModuleLifetime : UParticleModuleLifetimeBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}