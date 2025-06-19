namespace AssetTool
{
    [JsonAsset("ParticleModuleKillBox")]
    public class UParticleModuleKillBox : UParticleModuleKillBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}