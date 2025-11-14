namespace AssetTool
{
    [JsonAsset("MovieSceneAnimationTrackRecorder")]
    public class UMovieSceneAnimationTrackRecorder : UMovieSceneTrackRecorder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}