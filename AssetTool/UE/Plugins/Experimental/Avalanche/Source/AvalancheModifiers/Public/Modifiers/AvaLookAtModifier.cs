namespace AssetTool
{
    [JsonAsset("AvaLookAtModifier")]
    public class UAvaLookAtModifier : UAvaAttachmentBaseModifier
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}