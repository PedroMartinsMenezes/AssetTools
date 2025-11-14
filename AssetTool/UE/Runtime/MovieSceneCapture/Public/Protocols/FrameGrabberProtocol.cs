namespace AssetTool
{
    [JsonAsset("FrameGrabberProtocol")]
    public class UFrameGrabberProtocol : UMovieSceneImageCaptureProtocolBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}