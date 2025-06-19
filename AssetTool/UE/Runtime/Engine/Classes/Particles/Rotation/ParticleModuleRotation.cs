namespace AssetTool
{
    [JsonAsset("ParticleModuleRotation")]
    public class UParticleModuleRotation : UParticleModuleRotationBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}