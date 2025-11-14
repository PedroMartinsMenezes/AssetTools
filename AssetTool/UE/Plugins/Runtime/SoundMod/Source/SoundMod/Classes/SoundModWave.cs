namespace AssetTool
{
    [JsonAsset("SoundModWave")]
    public class USoundModWave : USoundWaveProcedural
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}