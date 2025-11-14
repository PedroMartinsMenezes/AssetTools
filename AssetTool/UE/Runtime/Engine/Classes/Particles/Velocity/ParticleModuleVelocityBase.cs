namespace AssetTool
{
    [JsonAsset("ParticleModuleVelocityBase")]
    public class UParticleModuleVelocityBase : UParticleModule
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}