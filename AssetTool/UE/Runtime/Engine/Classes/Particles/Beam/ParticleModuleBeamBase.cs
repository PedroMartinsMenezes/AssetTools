namespace AssetTool
{
    [JsonAsset("ParticleModuleBeamBase")]
    public class UParticleModuleBeamBase : UParticleModule
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}