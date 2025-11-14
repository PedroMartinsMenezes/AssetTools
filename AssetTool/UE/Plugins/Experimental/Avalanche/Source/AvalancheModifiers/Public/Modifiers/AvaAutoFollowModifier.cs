namespace AssetTool
{
    [JsonAsset("AvaAutoFollowModifier")]
    public class UAvaAutoFollowModifier : UAvaAttachmentBaseModifier
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}