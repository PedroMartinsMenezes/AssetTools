namespace AssetTool
{
    [JsonAsset("ParticleModuleEventReceiverBase")]
    public class UParticleModuleEventReceiverBase : UParticleModuleEventBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}