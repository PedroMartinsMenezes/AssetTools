namespace AssetTool
{
    [JsonAsset("AvaPlaybackNodeTrigger")]
    public class UAvaPlaybackNodeTrigger : UAvaPlaybackNodeEvent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}