namespace AssetTool
{
    [JsonAsset("MetaSoundSource")]
    public class UMetaSoundSource : USoundWaveProcedural
    {
        [Location("void UMetaSoundSource::Serialize(FArchive& InArchive)")]
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}