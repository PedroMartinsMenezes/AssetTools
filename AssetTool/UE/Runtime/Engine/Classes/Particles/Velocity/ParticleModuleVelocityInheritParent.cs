namespace AssetTool
{
    [JsonAsset("ParticleModuleVelocityInheritParent")]
    public class UParticleModuleVelocityInheritParent : UParticleModuleVelocityBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}