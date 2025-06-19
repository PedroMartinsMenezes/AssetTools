namespace AssetTool
{
    [JsonAsset("AvaPlaybackNodePlayer")]
    public class UAvaPlaybackNodePlayer : UAvaPlaybackNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}