namespace AssetTool
{
    [JsonAsset("VideoCaptureProtocol")]
    public class UVideoCaptureProtocol : UFrameGrabberProtocol
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}