namespace AssetTool
{
    [JsonAsset("ParticleModulePivotOffset")]
    public class UParticleModulePivotOffset : UParticleModuleLocationBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}