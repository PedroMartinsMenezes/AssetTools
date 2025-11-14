namespace AssetTool
{
    [JsonAsset("AvaPlaybackNodeAction")]
    public class UAvaPlaybackNodeAction : UAvaPlaybackNodeEvent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}