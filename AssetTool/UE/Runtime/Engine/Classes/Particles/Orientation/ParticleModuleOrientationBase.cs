namespace AssetTool
{
    [JsonAsset("ParticleModuleOrientationBase")]
    public class UParticleModuleOrientationBase : UParticleModule
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}