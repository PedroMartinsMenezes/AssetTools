namespace AssetTool
{
    [JsonAsset("ParticleModuleCameraBase")]
    public class UParticleModuleCameraBase : UParticleModule
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}