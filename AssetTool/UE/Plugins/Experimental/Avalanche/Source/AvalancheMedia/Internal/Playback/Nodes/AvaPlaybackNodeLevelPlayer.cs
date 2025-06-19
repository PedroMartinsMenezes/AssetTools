namespace AssetTool
{
    [JsonAsset("AvaPlaybackNodeLevelPlayer")]
    public class UAvaPlaybackNodeLevelPlayer : UAvaPlaybackNodePlayer
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}