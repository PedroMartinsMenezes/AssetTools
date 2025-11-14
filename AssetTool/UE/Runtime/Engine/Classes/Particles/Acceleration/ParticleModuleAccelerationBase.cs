namespace AssetTool
{
    [JsonAsset("ParticleModuleAccelerationBase")]
    public class UParticleModuleAccelerationBase : UParticleModule
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}