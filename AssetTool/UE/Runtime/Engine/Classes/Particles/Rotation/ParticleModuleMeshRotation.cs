namespace AssetTool
{
    [JsonAsset("ParticleModuleMeshRotation")]
    public class UParticleModuleMeshRotation : UParticleModuleRotationBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}