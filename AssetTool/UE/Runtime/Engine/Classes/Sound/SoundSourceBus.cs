namespace AssetTool
{
    [JsonAsset("SoundSourceBus")]
    public class USoundSourceBus : USoundWave
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}