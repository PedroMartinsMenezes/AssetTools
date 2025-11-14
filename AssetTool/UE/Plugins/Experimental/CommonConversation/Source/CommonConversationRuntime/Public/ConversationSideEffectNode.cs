namespace AssetTool
{
    [JsonAsset("ConversationSideEffectNode")]
    public class UConversationSideEffectNode : UConversationSubNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}