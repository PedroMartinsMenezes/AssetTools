namespace AssetTool
{
    [JsonAsset("ParticleModuleLocation")]
    public class UParticleModuleLocation : UParticleModuleLocationBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}