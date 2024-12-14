namespace AssetTool
{
    [JsonAsset("ParticleModuleParameterBase")]
    public class UParticleModuleParameterBase : UParticleModule
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}