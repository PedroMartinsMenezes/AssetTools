namespace AssetTool
{
    [JsonAsset("ConversationTaskNode")]
    public class UConversationTaskNode : UConversationNodeWithLinks
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}