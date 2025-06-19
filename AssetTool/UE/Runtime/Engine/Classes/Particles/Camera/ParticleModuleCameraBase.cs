namespace AssetTool
{
    [JsonAsset("ParticleModuleCameraBase")]
    public class UParticleModuleCameraBase : UParticleModule
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}