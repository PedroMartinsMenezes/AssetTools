namespace AssetTool
{
    [JsonAsset("ParticleModuleAttractorBase")]
    public class UParticleModuleAttractorBase : UParticleModule
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}