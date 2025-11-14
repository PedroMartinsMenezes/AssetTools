namespace AssetTool
{
    [JsonAsset("AvaPlaybackNodeTrigger")]
    public class UAvaPlaybackNodeTrigger : UAvaPlaybackNodeEvent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}