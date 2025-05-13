namespace AssetTool
{
    [JsonAsset("CompositingCaptureBase")]
    public class ACompositingCaptureBase : ACompositingElement
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}