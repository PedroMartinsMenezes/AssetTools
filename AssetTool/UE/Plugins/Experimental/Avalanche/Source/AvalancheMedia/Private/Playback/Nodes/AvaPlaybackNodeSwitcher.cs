namespace AssetTool
{
    [JsonAsset("AvaPlaybackNodeSwitcher")]
    public class UAvaPlaybackNodeSwitcher : UAvaPlaybackNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}