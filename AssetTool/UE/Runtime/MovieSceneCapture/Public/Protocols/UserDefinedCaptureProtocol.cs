namespace AssetTool
{
    [JsonAsset("UserDefinedCaptureProtocol")]
    public class UUserDefinedCaptureProtocol : UMovieSceneImageCaptureProtocolBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UserDefinedImageCaptureProtocol")]
    public class UUserDefinedImageCaptureProtocol : UUserDefinedCaptureProtocol
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}