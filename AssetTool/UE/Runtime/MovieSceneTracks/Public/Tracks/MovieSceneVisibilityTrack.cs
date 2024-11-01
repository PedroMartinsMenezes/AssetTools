namespace AssetTool
{
    [JsonAsset("MovieSceneVisibilityTrack")]
    public class UMovieSceneVisibilityTrack : UMovieSceneBoolTrack
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}