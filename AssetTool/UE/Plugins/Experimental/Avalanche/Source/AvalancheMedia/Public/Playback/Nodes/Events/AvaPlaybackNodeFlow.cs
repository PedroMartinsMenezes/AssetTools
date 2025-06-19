namespace AssetTool
{
    [JsonAsset("AvaPlaybackNodeFlow")]
    public class UAvaPlaybackNodeFlow : UAvaPlaybackNodeEvent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}