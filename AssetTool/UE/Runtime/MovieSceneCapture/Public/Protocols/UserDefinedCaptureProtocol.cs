namespace AssetTool
{
    [JsonAsset("UserDefinedCaptureProtocol")]
    public class UUserDefinedCaptureProtocol : UMovieSceneImageCaptureProtocolBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UserDefinedImageCaptureProtocol")]
    public class UUserDefinedImageCaptureProtocol : UUserDefinedCaptureProtocol
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}