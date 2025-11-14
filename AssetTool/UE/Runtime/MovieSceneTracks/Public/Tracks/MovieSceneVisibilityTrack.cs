namespace AssetTool
{
    [JsonAsset("MovieSceneVisibilityTrack")]
    public class UMovieSceneVisibilityTrack : UMovieSceneBoolTrack
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}