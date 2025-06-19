namespace AssetTool
{
    [JsonAsset("ParticleModulePivotOffset")]
    public class UParticleModulePivotOffset : UParticleModuleLocationBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}