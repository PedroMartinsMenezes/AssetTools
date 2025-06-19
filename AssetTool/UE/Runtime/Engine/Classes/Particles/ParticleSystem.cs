namespace AssetTool
{
    [JsonAsset("FXSystemAsset")]
    public class UFXSystemAsset : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ParticleSystem")]
    public class UParticleSystem : UFXSystemAsset
    {
        [Location("void UParticleSystem::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
