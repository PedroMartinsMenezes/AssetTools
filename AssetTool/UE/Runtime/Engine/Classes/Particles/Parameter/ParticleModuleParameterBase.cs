namespace AssetTool
{
    [JsonAsset("ParticleModuleParameterBase")]
    public class UParticleModuleParameterBase : UParticleModule
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}