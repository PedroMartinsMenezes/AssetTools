namespace AssetTool
{
    [JsonAsset("MovieSceneSubTrack")]
    public class UMovieSceneSubTrack : UMovieSceneNameableTrack
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}