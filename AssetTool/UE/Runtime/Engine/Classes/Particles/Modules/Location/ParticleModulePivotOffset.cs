namespace AssetTool
{
    [JsonAsset("ParticleModulePivotOffset")]
    public class UParticleModulePivotOffset : UParticleModuleLocationBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}