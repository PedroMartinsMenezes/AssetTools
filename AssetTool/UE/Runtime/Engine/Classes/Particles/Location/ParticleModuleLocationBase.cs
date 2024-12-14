namespace AssetTool
{
    [JsonAsset("ParticleModuleLocationBase")]
    public class UParticleModuleLocationBase : UParticleModule
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}