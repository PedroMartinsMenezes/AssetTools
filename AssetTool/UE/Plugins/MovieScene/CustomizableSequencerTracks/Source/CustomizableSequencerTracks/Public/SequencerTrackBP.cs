namespace AssetTool
{
    [JsonAsset("SequencerTrackBP")]
    public class USequencerTrackBP : UMovieSceneNameableTrack
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}