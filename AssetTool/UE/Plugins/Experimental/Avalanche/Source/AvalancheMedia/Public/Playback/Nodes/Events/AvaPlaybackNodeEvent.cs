namespace AssetTool
{
    [JsonAsset("AvaPlaybackNodeEvent")]
    public class UAvaPlaybackNodeEvent : UAvaPlaybackNode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}