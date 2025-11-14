namespace AssetTool
{
    [JsonAsset("ConversationGraphSchema")]
    public class UConversationGraphSchema : UAIGraphSchema
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}