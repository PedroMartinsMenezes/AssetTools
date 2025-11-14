namespace AssetTool
{
    [JsonAsset("PixelStreamingMediaIOCapture")]
    public class UPixelStreamingMediaIOCapture : UMediaCapture
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}