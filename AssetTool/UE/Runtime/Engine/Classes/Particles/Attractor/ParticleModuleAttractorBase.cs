namespace AssetTool
{
    [JsonAsset("ParticleModuleAttractorBase")]
    public class UParticleModuleAttractorBase : UParticleModule
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}