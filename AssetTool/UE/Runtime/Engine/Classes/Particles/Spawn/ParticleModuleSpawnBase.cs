namespace AssetTool
{
    [JsonAsset("ParticleModuleSpawnBase")]
    public class UParticleModuleSpawnBase : UParticleModule
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}