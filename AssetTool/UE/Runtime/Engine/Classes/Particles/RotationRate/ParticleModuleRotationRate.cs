namespace AssetTool
{
    [JsonAsset("ParticleModuleRotationRate")]
    public class UParticleModuleRotationRate : UParticleModuleRotationRateBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}