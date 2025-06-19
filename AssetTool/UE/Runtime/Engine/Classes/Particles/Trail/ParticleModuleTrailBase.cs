namespace AssetTool
{
    [JsonAsset("ParticleModuleTrailBase")]
    public class UParticleModuleTrailBase : UParticleModule
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}