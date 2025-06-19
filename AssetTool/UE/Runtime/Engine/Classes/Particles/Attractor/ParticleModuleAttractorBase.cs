namespace AssetTool
{
    [JsonAsset("ParticleModuleAttractorBase")]
    public class UParticleModuleAttractorBase : UParticleModule
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}