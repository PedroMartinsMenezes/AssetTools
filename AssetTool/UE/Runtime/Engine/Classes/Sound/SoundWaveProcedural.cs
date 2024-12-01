namespace AssetTool
{
    [JsonAsset("SoundWaveProcedural")]
    public class USoundWaveProcedural : USoundWave
    {
        [Location("void USoundWaveProcedural::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            return USoundBaseMove(transfer);
        }
    }
}