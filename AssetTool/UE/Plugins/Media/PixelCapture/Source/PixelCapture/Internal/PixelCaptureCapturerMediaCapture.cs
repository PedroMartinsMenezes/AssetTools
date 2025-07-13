namespace AssetTool
{
    [JsonAsset("PixelCaptureMediaOuput")]
    public class UPixelCaptureMediaOuput : UMediaOutput
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PixelCaptureMediaCapture")]
    public class UPixelCaptureMediaCapture : UMediaCapture
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}