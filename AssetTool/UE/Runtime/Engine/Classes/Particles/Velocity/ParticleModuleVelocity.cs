namespace AssetTool
{
    [JsonAsset("ParticleModuleVelocity")]
    public class UParticleModuleVelocity : UParticleModuleVelocityBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}