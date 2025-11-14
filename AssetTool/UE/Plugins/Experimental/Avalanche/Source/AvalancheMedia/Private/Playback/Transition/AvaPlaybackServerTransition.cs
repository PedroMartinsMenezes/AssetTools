namespace AssetTool
{
    [JsonAsset("AvaPlaybackServerTransition")]
    public class UAvaPlaybackServerTransition : UAvaPlaybackTransition
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}