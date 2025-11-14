namespace AssetTool
{
    [JsonAsset("ParticleModuleVelocityInheritParent")]
    public class UParticleModuleVelocityInheritParent : UParticleModuleVelocityBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}