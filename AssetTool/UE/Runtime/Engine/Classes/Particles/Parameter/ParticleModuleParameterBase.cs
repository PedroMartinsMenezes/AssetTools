namespace AssetTool
{
    [JsonAsset("ParticleModuleParameterBase")]
    public class UParticleModuleParameterBase : UParticleModule
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}