namespace AssetTool
{
    [JsonAsset("AvaAutoFollowModifier")]
    public class UAvaAutoFollowModifier : UAvaAttachmentBaseModifier
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}