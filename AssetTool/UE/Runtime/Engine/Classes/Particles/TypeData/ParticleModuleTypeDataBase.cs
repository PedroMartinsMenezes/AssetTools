namespace AssetTool
{
    [JsonAsset("ParticleModuleTypeDataBase")]
    public class UParticleModuleTypeDataBase : UParticleModule
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}