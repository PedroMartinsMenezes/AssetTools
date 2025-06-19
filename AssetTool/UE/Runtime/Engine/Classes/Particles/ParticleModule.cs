namespace AssetTool
{
    [JsonAsset("ParticleModule")]
    public class UParticleModule : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}