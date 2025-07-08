namespace AssetTool
{
    [JsonAsset("AjaFrameGrabberProtocol")]
    public class UAjaFrameGrabberProtocol : UMovieSceneImageCaptureProtocolBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}