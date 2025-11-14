namespace AssetTool
{
    [JsonAsset("ParticleModuleTypeDataBase")]
    public class UParticleModuleTypeDataBase : UParticleModule
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}