namespace AssetTool
{
    [JsonAsset("ParticleModuleRotationBase")]
    public class UParticleModuleRotationBase : UParticleModule
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}