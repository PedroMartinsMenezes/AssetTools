namespace AssetTool
{
    [JsonAsset("SoundModWave")]
    public class USoundModWave : USoundWaveProcedural
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}