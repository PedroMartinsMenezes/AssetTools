namespace AssetTool
{
    [JsonAsset("FXSystemAsset")]
    public class UFXSystemAsset : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ParticleSystem")]
    public class UParticleSystem : UFXSystemAsset
    {
        [Location("void UParticleSystem::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
