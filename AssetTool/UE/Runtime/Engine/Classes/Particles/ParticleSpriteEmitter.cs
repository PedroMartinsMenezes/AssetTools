namespace AssetTool
{
    [JsonAsset("ParticleSpriteEmitter")]
    public class UParticleSpriteEmitter : UParticleEmitter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}