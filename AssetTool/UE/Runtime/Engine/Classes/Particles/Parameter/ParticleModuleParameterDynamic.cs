namespace AssetTool
{
    [JsonAsset("ParticleModuleParameterDynamic")]
    public class UParticleModuleParameterDynamic : UParticleModuleParameterBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}