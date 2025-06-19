namespace AssetTool
{
    [JsonAsset("ParticleModuleRotationBase")]
    public class UParticleModuleRotationBase : UParticleModule
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}