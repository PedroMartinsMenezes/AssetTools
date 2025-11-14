namespace AssetTool
{
    [JsonAsset("ConversationTaskNode")]
    public class UConversationTaskNode : UConversationNodeWithLinks
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}