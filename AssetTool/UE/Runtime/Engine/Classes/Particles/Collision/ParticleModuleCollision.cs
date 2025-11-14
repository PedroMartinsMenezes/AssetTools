namespace AssetTool
{
    [JsonAsset("ParticleModuleCollision")]
    public class UParticleModuleCollision : UParticleModuleCollisionBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}