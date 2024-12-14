namespace AssetTool
{
    [JsonAsset("ParticleModuleVelocityInheritParent")]
    public class UParticleModuleVelocityInheritParent : UParticleModuleVelocityBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}