namespace AssetTool
{
    [JsonAsset("ParticleModuleLocationWorldOffset")]
    public class UParticleModuleLocationWorldOffset : UParticleModuleLocation
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}