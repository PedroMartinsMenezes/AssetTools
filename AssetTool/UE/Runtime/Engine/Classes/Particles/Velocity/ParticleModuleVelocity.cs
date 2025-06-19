namespace AssetTool
{
    [JsonAsset("ParticleModuleVelocity")]
    public class UParticleModuleVelocity : UParticleModuleVelocityBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}