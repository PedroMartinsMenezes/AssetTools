namespace AssetTool
{
    [JsonAsset("SequencerPlaylistItem")]
    public class USequencerPlaylistItem : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}