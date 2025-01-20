namespace AssetTool
{
    [JsonAsset("ColorConverterOutputPass")]
    public class UColorConverterOutputPass : UCompositingElementOutput
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CompositingMediaCaptureOutput")]
    public class UCompositingMediaCaptureOutput : UColorConverterOutputPass
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RenderTargetCompositingOutput")]
    public class URenderTargetCompositingOutput : UCompositingElementOutput
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EXRFileCompositingOutput")]
    public class UEXRFileCompositingOutput : UCompositingElementOutput
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}