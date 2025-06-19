namespace AssetTool
{
    [JsonAsset("ParticleModuleVelocityBase")]
    public class UParticleModuleVelocityBase : UParticleModule
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}