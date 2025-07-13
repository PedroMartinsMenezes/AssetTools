namespace AssetTool
{
    [JsonAsset("SequencerTrackBP")]
    public class USequencerTrackBP : UMovieSceneNameableTrack
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}