namespace AssetTool
{
    [JsonAsset("ParticleModuleKillBase")]
    public class UParticleModuleKillBase : UParticleModule
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}