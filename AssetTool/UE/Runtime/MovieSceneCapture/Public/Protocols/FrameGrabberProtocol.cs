namespace AssetTool
{
    [JsonAsset("FrameGrabberProtocol")]
    public class UFrameGrabberProtocol : UMovieSceneImageCaptureProtocolBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}