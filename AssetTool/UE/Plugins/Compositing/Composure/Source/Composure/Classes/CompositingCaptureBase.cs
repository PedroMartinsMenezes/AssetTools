namespace AssetTool
{
    [JsonAsset("CompositingCaptureBase")]
    public class ACompositingCaptureBase : ACompositingElement
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}