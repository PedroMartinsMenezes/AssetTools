namespace AssetTool
{
    [JsonAsset("SoundSourceBus")]
    public class USoundSourceBus : USoundWave
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}