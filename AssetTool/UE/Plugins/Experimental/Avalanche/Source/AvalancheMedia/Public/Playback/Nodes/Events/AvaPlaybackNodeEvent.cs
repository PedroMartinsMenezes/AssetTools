namespace AssetTool
{
    [JsonAsset("AvaPlaybackNodeEvent")]
    public class UAvaPlaybackNodeEvent : UAvaPlaybackNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}