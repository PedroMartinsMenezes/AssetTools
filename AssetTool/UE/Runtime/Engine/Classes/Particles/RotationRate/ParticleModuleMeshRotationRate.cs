namespace AssetTool
{
    [JsonAsset("ParticleModuleMeshRotationRate")]
    public class UParticleModuleMeshRotationRate : UParticleModuleRotationRateBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}