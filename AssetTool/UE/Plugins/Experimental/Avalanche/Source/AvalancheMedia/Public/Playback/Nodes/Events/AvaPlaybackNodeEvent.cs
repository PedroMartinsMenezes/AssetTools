namespace AssetTool
{
    [JsonAsset("AvaPlaybackNodeEvent")]
    public class UAvaPlaybackNodeEvent : UAvaPlaybackNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}