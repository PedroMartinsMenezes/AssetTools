namespace AssetTool
{
    [JsonAsset("MovieSceneAnimatorTrack")]
    public class UMovieSceneAnimatorTrack : UMovieSceneNameableTrack
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}