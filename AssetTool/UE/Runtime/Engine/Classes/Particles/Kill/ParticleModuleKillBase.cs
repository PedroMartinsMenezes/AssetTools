namespace AssetTool
{
    [JsonAsset("ParticleModuleKillBase")]
    public class UParticleModuleKillBase : UParticleModule
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}