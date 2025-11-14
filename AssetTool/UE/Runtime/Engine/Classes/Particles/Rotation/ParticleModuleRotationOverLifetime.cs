namespace AssetTool
{
    [JsonAsset("ParticleModuleRotationOverLifetime")]
    public class UParticleModuleRotationOverLifetime : UParticleModuleRotationBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}