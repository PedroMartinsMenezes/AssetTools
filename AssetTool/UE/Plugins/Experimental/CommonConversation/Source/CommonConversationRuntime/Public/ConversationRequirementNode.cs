namespace AssetTool
{
    [JsonAsset("ConversationRequirementNode")]
    public class UConversationRequirementNode : UConversationSubNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}