namespace AssetTool
{
    [JsonAsset("ParticleModuleVelocityCone")]
    public class UParticleModuleVelocityCone : UParticleModuleVelocityBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}