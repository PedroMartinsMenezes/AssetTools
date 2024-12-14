namespace AssetTool
{
    [JsonAsset("ParticleModuleVelocityBase")]
    public class UParticleModuleVelocityBase : UParticleModule
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}