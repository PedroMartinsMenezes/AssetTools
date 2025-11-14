namespace AssetTool
{
    [JsonAsset("ParticleModuleEventBase")]
    public class UParticleModuleEventBase : UParticleModule
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}