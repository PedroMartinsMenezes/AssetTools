namespace AssetTool
{
    [JsonAsset("ParticleModuleSourceMovement")]
    public class UParticleModuleSourceMovement : UParticleModuleLocationBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}