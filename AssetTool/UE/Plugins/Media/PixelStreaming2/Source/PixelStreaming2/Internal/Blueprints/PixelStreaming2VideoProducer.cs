namespace AssetTool
{
    [JsonAsset("PixelStreaming2VideoProducer")]
    public class UPixelStreaming2VideoProducer : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PixelStreaming2VideoProducerBackBuffer")]
    public class UPixelStreaming2VideoProducerBackBuffer : UPixelStreaming2VideoProducer
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PixelStreaming2VideoProducerMediaCapture")]
    public class UPixelStreaming2VideoProducerMediaCapture : UPixelStreaming2VideoProducer
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PixelStreaming2VideoProducerRenderTarget")]
    public class UPixelStreaming2VideoProducerRenderTarget : UPixelStreaming2VideoProducer
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}