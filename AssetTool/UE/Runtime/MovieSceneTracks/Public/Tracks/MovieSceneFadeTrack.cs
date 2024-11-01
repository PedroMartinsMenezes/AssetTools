namespace AssetTool
{
    [JsonAsset("MovieSceneFadeTrack")]
    public class UMovieSceneFadeTrack : UMovieSceneFloatTrack
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}