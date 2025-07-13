namespace AssetTool
{
    [JsonAsset("ConversationSideEffectNode")]
    public class UConversationSideEffectNode : UConversationSubNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}