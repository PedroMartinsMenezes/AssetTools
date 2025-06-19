namespace AssetTool
{
    [JsonAsset("AvaPlaybackNodeAction")]
    public class UAvaPlaybackNodeAction : UAvaPlaybackNodeEvent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}