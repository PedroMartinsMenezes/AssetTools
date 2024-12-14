namespace AssetTool
{
    [JsonAsset("ParticleModuleOrbit")]
    public class UParticleModuleOrbit : UParticleModuleOrbitBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}