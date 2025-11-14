namespace AssetTool
{
    [JsonAsset("PartialNetObjectAttachmentHandlerConfig")]
    public class UPartialNetObjectAttachmentHandlerConfig : USequentialPartialNetBlobHandlerConfig
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PartialNetObjectAttachmentHandler")]
    public class UPartialNetObjectAttachmentHandler : USequentialPartialNetBlobHandler
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}