namespace AssetTool
{
    [JsonAsset("ParticleModuleAccelerationBase")]
    public class UParticleModuleAccelerationBase : UParticleModule
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}