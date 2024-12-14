namespace AssetTool
{
    [JsonAsset("ParticleModuleMaterialBase")]
    public class UParticleModuleMaterialBase : UParticleModule
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}