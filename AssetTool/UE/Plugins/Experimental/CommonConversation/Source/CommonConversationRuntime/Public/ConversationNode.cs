namespace AssetTool
{
    [JsonAsset("ConversationNode")]
    public class UConversationNode : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ConversationNodeWithLinks")]
    public class UConversationNodeWithLinks : UConversationNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}