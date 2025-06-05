namespace AssetTool
{
    [JsonAsset("AvaPlaybackNodeTrigger")]
    public class UAvaPlaybackNodeTrigger : UAvaPlaybackNodeEvent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}