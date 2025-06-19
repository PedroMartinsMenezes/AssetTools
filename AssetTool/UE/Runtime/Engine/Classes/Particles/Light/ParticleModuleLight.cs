namespace AssetTool
{
    [JsonAsset("ParticleModuleLight")]
    public class UParticleModuleLight : UParticleModuleLightBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}