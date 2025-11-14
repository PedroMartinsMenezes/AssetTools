namespace AssetTool
{
    [JsonAsset("AvaPlaybackNodeFlow")]
    public class UAvaPlaybackNodeFlow : UAvaPlaybackNodeEvent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}