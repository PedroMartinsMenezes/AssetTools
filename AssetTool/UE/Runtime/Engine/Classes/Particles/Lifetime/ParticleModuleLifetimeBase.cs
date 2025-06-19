namespace AssetTool
{
    [JsonAsset("ParticleModuleLifetimeBase")]
    public class UParticleModuleLifetimeBase : UParticleModule
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}