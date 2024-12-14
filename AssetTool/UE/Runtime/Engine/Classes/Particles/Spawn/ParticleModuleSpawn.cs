namespace AssetTool
{
    [JsonAsset("ParticleModuleSpawn")]
    public class UParticleModuleSpawn : UParticleModuleSpawnBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}