namespace AssetTool
{
    [JsonAsset("MovieSceneAnimatorTrack")]
    public class UMovieSceneAnimatorTrack : UMovieSceneNameableTrack
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}