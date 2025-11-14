namespace AssetTool
{
    [JsonAsset("MovieSceneCaptureProtocolBase")]
    public class UMovieSceneCaptureProtocolBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieSceneImageCaptureProtocolBase")]
    public class UMovieSceneImageCaptureProtocolBase : UMovieSceneCaptureProtocolBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieSceneAudioCaptureProtocolBase")]
    public class UMovieSceneAudioCaptureProtocolBase : UMovieSceneCaptureProtocolBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}