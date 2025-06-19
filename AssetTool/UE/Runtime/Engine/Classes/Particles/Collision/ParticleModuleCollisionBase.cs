namespace AssetTool
{
    [JsonAsset("ParticleModuleCollisionBase")]
    public class UParticleModuleCollisionBase : UParticleModule
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}