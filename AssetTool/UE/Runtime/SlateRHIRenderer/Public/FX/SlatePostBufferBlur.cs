namespace AssetTool
{
    [JsonAsset("SlatePostBufferBlur")]
    public class USlatePostBufferBlur : USlateRHIPostBufferProcessor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}