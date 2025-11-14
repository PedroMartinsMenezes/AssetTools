namespace AssetTool
{
    [JsonAsset("ParticleModuleLocationPrimitiveBase")]
    public class UParticleModuleLocationPrimitiveBase : UParticleModuleLocationBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}