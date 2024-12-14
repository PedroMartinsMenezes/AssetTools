namespace AssetTool
{
    [JsonAsset("ParticleSpriteEmitter")]
    public class UParticleSpriteEmitter : UParticleEmitter
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}