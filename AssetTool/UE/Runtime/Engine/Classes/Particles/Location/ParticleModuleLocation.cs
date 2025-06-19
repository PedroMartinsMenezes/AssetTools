namespace AssetTool
{
    [JsonAsset("ParticleModuleLocation")]
    public class UParticleModuleLocation : UParticleModuleLocationBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}