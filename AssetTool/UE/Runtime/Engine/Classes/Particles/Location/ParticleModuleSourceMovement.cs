namespace AssetTool
{
    [JsonAsset("ParticleModuleSourceMovement")]
    public class UParticleModuleSourceMovement : UParticleModuleLocationBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}