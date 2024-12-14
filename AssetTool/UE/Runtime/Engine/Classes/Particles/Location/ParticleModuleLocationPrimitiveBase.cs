namespace AssetTool
{
    [JsonAsset("ParticleModuleLocationPrimitiveBase")]
    public class UParticleModuleLocationPrimitiveBase : UParticleModuleLocationBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}