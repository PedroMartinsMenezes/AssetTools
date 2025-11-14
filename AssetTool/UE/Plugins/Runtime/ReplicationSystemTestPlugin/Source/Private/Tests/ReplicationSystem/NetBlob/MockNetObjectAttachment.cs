namespace AssetTool
{
    [JsonAsset("MockNetObjectAttachmentHandler")]
    public class UMockNetObjectAttachmentHandler : UNetBlobHandler
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}