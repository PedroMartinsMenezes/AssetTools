namespace AssetTool
{
    [JsonAsset("ParticleModuleSpawn")]
    public class UParticleModuleSpawn : UParticleModuleSpawnBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}