namespace AssetTool
{
    [JsonAsset("ParticleModuleSourceMovement")]
    public class UParticleModuleSourceMovement : UParticleModuleLocationBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}