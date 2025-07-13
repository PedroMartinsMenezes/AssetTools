namespace AssetTool
{
    [JsonAsset("SequencerPlaylistItem")]
    public class USequencerPlaylistItem : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}