namespace AssetTool
{
    [JsonAsset("ParticleModuleTrailBase")]
    public class UParticleModuleTrailBase : UParticleModule
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}