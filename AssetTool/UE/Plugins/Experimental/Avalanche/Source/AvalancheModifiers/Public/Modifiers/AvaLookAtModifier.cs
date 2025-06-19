namespace AssetTool
{
    [JsonAsset("AvaLookAtModifier")]
    public class UAvaLookAtModifier : UAvaAttachmentBaseModifier
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}