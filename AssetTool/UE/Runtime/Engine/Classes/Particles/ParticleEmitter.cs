namespace AssetTool
{
    [JsonAsset("ParticleEmitter")]
    public class UParticleEmitter : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}