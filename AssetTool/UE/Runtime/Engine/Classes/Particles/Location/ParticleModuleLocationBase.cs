namespace AssetTool
{
    [JsonAsset("ParticleModuleLocationBase")]
    public class UParticleModuleLocationBase : UParticleModule
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}