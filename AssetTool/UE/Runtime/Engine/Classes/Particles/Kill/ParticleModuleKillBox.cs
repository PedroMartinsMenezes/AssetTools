namespace AssetTool
{
    [JsonAsset("ParticleModuleKillBox")]
    public class UParticleModuleKillBox : UParticleModuleKillBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}