namespace AssetTool
{
    [JsonAsset("ParticleModuleLocationBase")]
    public class UParticleModuleLocationBase : UParticleModule
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}