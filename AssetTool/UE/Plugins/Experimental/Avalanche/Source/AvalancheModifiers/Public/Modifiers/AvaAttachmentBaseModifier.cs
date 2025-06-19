namespace AssetTool
{
    [JsonAsset("AvaAttachmentBaseModifier")]
    public class UAvaAttachmentBaseModifier : UAvaBaseModifier
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}