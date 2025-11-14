namespace AssetTool
{
    [JsonAsset("ParticleModuleOrientationBase")]
    public class UParticleModuleOrientationBase : UParticleModule
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}