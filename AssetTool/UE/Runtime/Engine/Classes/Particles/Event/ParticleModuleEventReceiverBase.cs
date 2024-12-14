namespace AssetTool
{
    [JsonAsset("ParticleModuleEventReceiverBase")]
    public class UParticleModuleEventReceiverBase : UParticleModuleEventBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}