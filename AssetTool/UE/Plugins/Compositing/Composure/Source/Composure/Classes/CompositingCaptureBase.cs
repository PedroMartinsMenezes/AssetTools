namespace AssetTool
{
    [JsonAsset("CompositingCaptureBase")]
    public class ACompositingCaptureBase : ACompositingElement
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}