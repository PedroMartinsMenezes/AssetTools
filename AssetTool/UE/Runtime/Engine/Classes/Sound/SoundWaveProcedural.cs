namespace AssetTool
{
    [JsonAsset("SoundWaveProcedural")]
    public class USoundWaveProcedural : USoundWave
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}