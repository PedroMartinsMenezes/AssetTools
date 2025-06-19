namespace AssetTool
{
    [JsonAsset("AvaArrangeBaseModifier")]
    public class UAvaArrangeBaseModifier : UAvaAttachmentBaseModifier
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}