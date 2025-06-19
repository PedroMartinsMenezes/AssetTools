namespace AssetTool
{
    [JsonAsset("ParticleModuleSizeBase")]
    public class UParticleModuleSizeBase : UParticleModule
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}