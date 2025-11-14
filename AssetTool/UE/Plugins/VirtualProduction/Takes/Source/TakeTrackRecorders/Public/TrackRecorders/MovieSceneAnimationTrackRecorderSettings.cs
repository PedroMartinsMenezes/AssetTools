namespace AssetTool
{
    [JsonAsset("MovieSceneAnimationTrackRecorderEditorSettings")]
    public class UMovieSceneAnimationTrackRecorderEditorSettings : UMovieSceneTrackRecorderSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieSceneAnimationTrackRecorderSettings")]
    public class UMovieSceneAnimationTrackRecorderSettings : UMovieSceneAnimationTrackRecorderEditorSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}