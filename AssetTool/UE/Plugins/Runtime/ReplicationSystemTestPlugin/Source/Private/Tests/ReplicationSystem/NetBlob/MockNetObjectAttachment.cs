namespace AssetTool
{
    [JsonAsset("MockNetObjectAttachmentHandler")]
    public class UMockNetObjectAttachmentHandler : UNetBlobHandler
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}