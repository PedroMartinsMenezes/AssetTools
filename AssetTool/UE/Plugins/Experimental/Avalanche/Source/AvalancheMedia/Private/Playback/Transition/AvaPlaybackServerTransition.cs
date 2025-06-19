namespace AssetTool
{
    [JsonAsset("AvaPlaybackServerTransition")]
    public class UAvaPlaybackServerTransition : UAvaPlaybackTransition
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}