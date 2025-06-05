namespace AssetTool
{
    [JsonAsset("AvaPlaybackNodeAction")]
    public class UAvaPlaybackNodeAction : UAvaPlaybackNodeEvent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}