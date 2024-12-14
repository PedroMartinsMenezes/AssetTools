namespace AssetTool
{
    [JsonAsset("ParticleModuleCameraBase")]
    public class UParticleModuleCameraBase : UParticleModule
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}