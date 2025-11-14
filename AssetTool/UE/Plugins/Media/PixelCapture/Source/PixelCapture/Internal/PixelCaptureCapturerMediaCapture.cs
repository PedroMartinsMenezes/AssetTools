namespace AssetTool
{
    [JsonAsset("PixelCaptureMediaOuput")]
    public class UPixelCaptureMediaOuput : UMediaOutput
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PixelCaptureMediaCapture")]
    public class UPixelCaptureMediaCapture : UMediaCapture
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}