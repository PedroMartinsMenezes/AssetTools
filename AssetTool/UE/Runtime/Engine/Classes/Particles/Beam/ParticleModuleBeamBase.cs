namespace AssetTool
{
    [JsonAsset("ParticleModuleBeamBase")]
    public class UParticleModuleBeamBase : UParticleModule
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}