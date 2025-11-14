namespace AssetTool
{
    [JsonAsset("NullAudioCaptureProtocol")]
    public class UNullAudioCaptureProtocol : UMovieSceneAudioCaptureProtocolBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MasterAudioSubmixCaptureProtocol")]
    public class UMasterAudioSubmixCaptureProtocol : UMovieSceneAudioCaptureProtocolBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}