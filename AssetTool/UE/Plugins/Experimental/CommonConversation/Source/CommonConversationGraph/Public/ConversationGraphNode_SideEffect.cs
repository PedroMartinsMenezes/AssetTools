namespace AssetTool
{
    [JsonAsset("ConversationGraphNode_SideEffect")]
    public class UConversationGraphNode_SideEffect : UConversationGraphNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}