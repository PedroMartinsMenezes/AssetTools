namespace AssetTool
{
    [JsonAsset("ConversationGraphNode")]
    public class UConversationGraphNode : UAIGraphNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}