namespace AssetTool
{
    [JsonAsset("ParticleModuleVelocity")]
    public class UParticleModuleVelocity : UParticleModuleVelocityBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}