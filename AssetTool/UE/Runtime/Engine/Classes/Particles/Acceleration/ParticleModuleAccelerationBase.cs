namespace AssetTool
{
    [JsonAsset("ParticleModuleAccelerationBase")]
    public class UParticleModuleAccelerationBase : UParticleModule
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}