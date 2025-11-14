namespace AssetTool
{
    [JsonAsset("ParticleModuleLight")]
    public class UParticleModuleLight : UParticleModuleLightBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}