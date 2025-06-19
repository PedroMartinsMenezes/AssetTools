namespace AssetTool
{
    [JsonAsset("ParticleModuleMaterialBase")]
    public class UParticleModuleMaterialBase : UParticleModule
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}