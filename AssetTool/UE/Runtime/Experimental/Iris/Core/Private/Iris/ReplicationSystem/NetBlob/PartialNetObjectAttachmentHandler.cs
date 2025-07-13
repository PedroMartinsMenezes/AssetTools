namespace AssetTool
{
    [JsonAsset("PartialNetObjectAttachmentHandlerConfig")]
    public class UPartialNetObjectAttachmentHandlerConfig : USequentialPartialNetBlobHandlerConfig
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PartialNetObjectAttachmentHandler")]
    public class UPartialNetObjectAttachmentHandler : USequentialPartialNetBlobHandler
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}