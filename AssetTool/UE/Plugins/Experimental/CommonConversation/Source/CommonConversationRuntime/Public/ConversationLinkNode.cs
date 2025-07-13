namespace AssetTool
{
    [JsonAsset("ConversationLinkNode")]
    public class UConversationLinkNode : UConversationTaskNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}