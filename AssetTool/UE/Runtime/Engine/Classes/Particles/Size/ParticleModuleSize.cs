namespace AssetTool
{
    [JsonAsset("ParticleModuleSize")]
    public class UParticleModuleSize : UParticleModuleSizeBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}