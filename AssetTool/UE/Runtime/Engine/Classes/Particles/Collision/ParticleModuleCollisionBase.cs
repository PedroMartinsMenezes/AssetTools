namespace AssetTool
{
    [JsonAsset("ParticleModuleCollisionBase")]
    public class UParticleModuleCollisionBase : UParticleModule
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}