namespace AssetTool
{
    [JsonAsset("ParticleModuleSpawn")]
    public class UParticleModuleSpawn : UParticleModuleSpawnBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}