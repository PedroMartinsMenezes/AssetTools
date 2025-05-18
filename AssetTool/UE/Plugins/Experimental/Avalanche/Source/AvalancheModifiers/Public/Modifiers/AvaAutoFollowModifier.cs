namespace AssetTool
{
    [JsonAsset("AvaAutoFollowModifier")]
    public class UAvaAutoFollowModifier : UAvaAttachmentBaseModifier
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}