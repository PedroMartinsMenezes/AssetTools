namespace AssetTool
{
    [JsonAsset("ConversationEntryPointNode")]
    public class UConversationEntryPointNode : UConversationNodeWithLinks
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}