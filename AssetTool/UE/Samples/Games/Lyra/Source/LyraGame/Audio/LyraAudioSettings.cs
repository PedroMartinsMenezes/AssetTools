namespace AssetTool
{
    [JsonAsset("LyraAudioSettings")]
    public class ULyraAudioSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}