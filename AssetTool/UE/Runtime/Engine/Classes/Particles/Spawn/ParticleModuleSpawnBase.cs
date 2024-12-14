namespace AssetTool
{
    [JsonAsset("ParticleModuleSpawnBase")]
    public class UParticleModuleSpawnBase : UParticleModule
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}