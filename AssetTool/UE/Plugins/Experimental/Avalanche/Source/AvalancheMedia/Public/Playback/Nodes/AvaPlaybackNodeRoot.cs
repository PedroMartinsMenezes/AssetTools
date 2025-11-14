namespace AssetTool
{
    [JsonAsset("AvaPlaybackNodeRoot")]
    public class UAvaPlaybackNodeRoot : UAvaPlaybackNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}