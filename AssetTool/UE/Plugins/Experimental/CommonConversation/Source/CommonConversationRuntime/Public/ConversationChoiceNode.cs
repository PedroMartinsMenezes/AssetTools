namespace AssetTool
{
    [JsonAsset("ConversationChoiceNode")]
    public class UConversationChoiceNode : UConversationSubNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}