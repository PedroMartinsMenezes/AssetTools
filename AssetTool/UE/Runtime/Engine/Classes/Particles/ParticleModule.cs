namespace AssetTool
{
    [JsonAsset("ParticleModule")]
    public class UParticleModule : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}