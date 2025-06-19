namespace AssetTool
{
    [JsonAsset("ParticleModuleEventBase")]
    public class UParticleModuleEventBase : UParticleModule
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}