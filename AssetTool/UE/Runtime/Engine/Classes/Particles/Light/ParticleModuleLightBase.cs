namespace AssetTool
{
    [JsonAsset("ParticleModuleLightBase")]
    public class UParticleModuleLightBase : UParticleModule
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}