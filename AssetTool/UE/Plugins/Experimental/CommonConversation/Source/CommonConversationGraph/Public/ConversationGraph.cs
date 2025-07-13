namespace AssetTool
{
    [JsonAsset("ConversationGraph")]
    public class UConversationGraph : UAIGraph
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}