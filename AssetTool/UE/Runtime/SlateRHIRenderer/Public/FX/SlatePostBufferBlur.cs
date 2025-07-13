namespace AssetTool
{
    [JsonAsset("SlatePostBufferBlur")]
    public class USlatePostBufferBlur : USlateRHIPostBufferProcessor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}