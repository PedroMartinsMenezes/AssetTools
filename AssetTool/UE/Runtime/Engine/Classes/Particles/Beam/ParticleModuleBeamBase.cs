namespace AssetTool
{
    [JsonAsset("ParticleModuleBeamBase")]
    public class UParticleModuleBeamBase : UParticleModule
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}