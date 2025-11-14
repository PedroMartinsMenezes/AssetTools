namespace AssetTool
{
    [JsonAsset("ParticleModuleAcceleration")]
    public class UParticleModuleAcceleration : UParticleModuleAccelerationBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}