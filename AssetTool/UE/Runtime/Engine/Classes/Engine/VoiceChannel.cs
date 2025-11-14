namespace AssetTool
{
    [JsonAsset("VoiceChannel")]
    public class UVoiceChannel : UChannel
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}