namespace AssetTool
{
    [JsonAsset("MovieSceneVisibilityTrack")]
    public class UMovieSceneVisibilityTrack : UMovieSceneBoolTrack
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}