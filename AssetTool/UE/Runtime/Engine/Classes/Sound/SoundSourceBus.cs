namespace AssetTool
{
    [JsonAsset("SoundSourceBus")]
    public class USoundSourceBus : USoundWave
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}