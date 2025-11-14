namespace AssetTool
{
    [JsonAsset("AvaPlaybackNodeLevelPlayer")]
    public class UAvaPlaybackNodeLevelPlayer : UAvaPlaybackNodePlayer
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}