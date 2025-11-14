namespace AssetTool
{
    [JsonAsset("ParticleModuleSizeBase")]
    public class UParticleModuleSizeBase : UParticleModule
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}