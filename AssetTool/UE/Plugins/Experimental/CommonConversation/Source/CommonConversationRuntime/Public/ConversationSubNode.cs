namespace AssetTool
{
    [JsonAsset("ConversationSubNode")]
    public class UConversationSubNode : UConversationNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}