namespace AssetTool
{
    [JsonAsset("ParticleModuleOrbitBase")]
    public class UParticleModuleOrbitBase : UParticleModule
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}