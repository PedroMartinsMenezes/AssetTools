namespace AssetTool
{
    [JsonAsset("ParticleModuleCollisionBase")]
    public class UParticleModuleCollisionBase : UParticleModule
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}