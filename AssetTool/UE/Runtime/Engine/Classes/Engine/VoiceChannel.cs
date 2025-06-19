namespace AssetTool
{
    [JsonAsset("VoiceChannel")]
    public class UVoiceChannel : UChannel
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}