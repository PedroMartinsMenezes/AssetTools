namespace AssetTool
{
    [JsonAsset("NullAudioCaptureProtocol")]
    public class UNullAudioCaptureProtocol : UMovieSceneAudioCaptureProtocolBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MasterAudioSubmixCaptureProtocol")]
    public class UMasterAudioSubmixCaptureProtocol : UMovieSceneAudioCaptureProtocolBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}