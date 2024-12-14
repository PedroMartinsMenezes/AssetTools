namespace AssetTool
{
    [JsonAsset("ParticleModuleAcceleration")]
    public class UParticleModuleAcceleration : UParticleModuleAccelerationBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}