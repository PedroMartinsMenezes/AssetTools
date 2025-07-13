namespace AssetTool
{
    [JsonAsset("ConversationEntryPointNode")]
    public class UConversationEntryPointNode : UConversationNodeWithLinks
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}