namespace AssetTool
{
    [JsonAsset("ParticleModuleEventBase")]
    public class UParticleModuleEventBase : UParticleModule
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}