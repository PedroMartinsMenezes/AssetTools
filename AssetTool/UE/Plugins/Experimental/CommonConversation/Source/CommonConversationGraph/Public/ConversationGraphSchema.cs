namespace AssetTool
{
    [JsonAsset("ConversationGraphSchema")]
    public class UConversationGraphSchema : UAIGraphSchema
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}