namespace AssetTool
{
    [JsonAsset("VideoCaptureProtocol")]
    public class UVideoCaptureProtocol : UFrameGrabberProtocol
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}