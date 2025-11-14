namespace AssetTool
{
    [JsonAsset("ParticleModuleLifetimeBase")]
    public class UParticleModuleLifetimeBase : UParticleModule
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}