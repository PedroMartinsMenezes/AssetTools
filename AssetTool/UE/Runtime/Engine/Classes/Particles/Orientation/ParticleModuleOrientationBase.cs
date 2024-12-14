namespace AssetTool
{
    [JsonAsset("ParticleModuleOrientationBase")]
    public class UParticleModuleOrientationBase : UParticleModule
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}