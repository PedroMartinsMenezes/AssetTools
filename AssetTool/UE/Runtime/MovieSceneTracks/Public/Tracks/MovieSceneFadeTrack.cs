namespace AssetTool
{
    [JsonAsset("MovieSceneFadeTrack")]
    public class UMovieSceneFadeTrack : UMovieSceneFloatTrack
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}