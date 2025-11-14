namespace AssetTool
{
    [JsonAsset("ParticleModuleSpawnPerUnit")]
    public class UParticleModuleSpawnPerUnit : UParticleModuleSpawnBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}