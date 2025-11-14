namespace AssetTool
{
    [JsonAsset("ParticleEmitter")]
    public class UParticleEmitter : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}