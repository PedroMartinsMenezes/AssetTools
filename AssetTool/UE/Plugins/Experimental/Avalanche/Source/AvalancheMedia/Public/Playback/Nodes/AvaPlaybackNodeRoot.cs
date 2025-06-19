namespace AssetTool
{
    [JsonAsset("AvaPlaybackNodeRoot")]
    public class UAvaPlaybackNodeRoot : UAvaPlaybackNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}