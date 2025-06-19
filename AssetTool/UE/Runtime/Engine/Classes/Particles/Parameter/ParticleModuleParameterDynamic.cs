namespace AssetTool
{
    [JsonAsset("ParticleModuleParameterDynamic")]
    public class UParticleModuleParameterDynamic : UParticleModuleParameterBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}