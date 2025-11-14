namespace AssetTool
{
    [JsonAsset("ParticleModuleSpawnBase")]
    public class UParticleModuleSpawnBase : UParticleModule
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}