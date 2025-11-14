namespace AssetTool
{
    [JsonAsset("ParticleModuleLocation")]
    public class UParticleModuleLocation : UParticleModuleLocationBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}