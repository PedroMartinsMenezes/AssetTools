namespace AssetTool
{
    [JsonAsset("AvaArrangeBaseModifier")]
    public class UAvaArrangeBaseModifier : UAvaAttachmentBaseModifier
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}