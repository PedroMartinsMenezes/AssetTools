namespace AssetTool
{
    [JsonAsset("ParticleModuleLifetimeBase")]
    public class UParticleModuleLifetimeBase : UParticleModule
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}