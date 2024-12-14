namespace AssetTool
{
    [JsonAsset("ParticleModuleRotationBase")]
    public class UParticleModuleRotationBase : UParticleModule
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}