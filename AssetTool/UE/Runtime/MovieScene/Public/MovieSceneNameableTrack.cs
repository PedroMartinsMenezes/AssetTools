namespace AssetTool
{
    [JsonAsset("MovieSceneNameableTrack")]
    public class UMovieSceneNameableTrack : UMovieSceneTrack
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}