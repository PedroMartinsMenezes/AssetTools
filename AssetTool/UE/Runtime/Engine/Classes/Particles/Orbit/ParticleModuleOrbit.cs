namespace AssetTool
{
    [JsonAsset("ParticleModuleOrbit")]
    public class UParticleModuleOrbit : UParticleModuleOrbitBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}