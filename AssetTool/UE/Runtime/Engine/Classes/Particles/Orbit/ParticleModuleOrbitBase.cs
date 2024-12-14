namespace AssetTool
{
    [JsonAsset("ParticleModuleOrbitBase")]
    public class UParticleModuleOrbitBase : UParticleModule
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}