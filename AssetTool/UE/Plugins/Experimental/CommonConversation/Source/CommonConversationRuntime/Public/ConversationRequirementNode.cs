namespace AssetTool
{
    [JsonAsset("ConversationRequirementNode")]
    public class UConversationRequirementNode : UConversationSubNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}