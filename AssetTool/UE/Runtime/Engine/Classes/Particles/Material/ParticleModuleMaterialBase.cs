namespace AssetTool
{
    [JsonAsset("ParticleModuleMaterialBase")]
    public class UParticleModuleMaterialBase : UParticleModule
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}