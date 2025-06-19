namespace AssetTool
{
    [JsonAsset("ParticleModuleEventReceiverBase")]
    public class UParticleModuleEventReceiverBase : UParticleModuleEventBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}