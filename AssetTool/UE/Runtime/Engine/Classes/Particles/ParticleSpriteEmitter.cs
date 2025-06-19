namespace AssetTool
{
    [JsonAsset("ParticleSpriteEmitter")]
    public class UParticleSpriteEmitter : UParticleEmitter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}