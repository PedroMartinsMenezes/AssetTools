namespace AssetTool
{
    [JsonAsset("ParticleModuleOrbit")]
    public class UParticleModuleOrbit : UParticleModuleOrbitBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}