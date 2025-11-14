namespace AssetTool
{
    [JsonAsset("SoundWaveProcedural")]
    public class USoundWaveProcedural : USoundWave
    {
        [Location("void USoundWaveProcedural::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            return USoundBaseMove(transfer);
        }
    }
}