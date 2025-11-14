namespace AssetTool
{
    [JsonAsset("AvaPlaybackNodePlayer")]
    public class UAvaPlaybackNodePlayer : UAvaPlaybackNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}