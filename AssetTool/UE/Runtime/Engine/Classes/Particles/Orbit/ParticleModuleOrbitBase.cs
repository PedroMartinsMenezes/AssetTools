namespace AssetTool
{
    [JsonAsset("ParticleModuleOrbitBase")]
    public class UParticleModuleOrbitBase : UParticleModule
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}