namespace AssetTool
{
    [JsonAsset("MovieScene3DTransformTrackRecorder")]
    public class UMovieScene3DTransformTrackRecorder : UMovieSceneTrackRecorder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}