namespace AssetTool
{
    [JsonAsset("ParticleModuleMeshRotationRate")]
    public class UParticleModuleMeshRotationRate : UParticleModuleRotationRateBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}