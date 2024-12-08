namespace AssetTool
{
    [JsonAsset("VoiceChannel")]
    public class UVoiceChannel : UChannel
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}